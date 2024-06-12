package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.preference.PreferenceManager
import android.util.Log
import android.view.LayoutInflater
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.appcompat.widget.Toolbar
import androidx.navigation.findNavController
import androidx.navigation.ui.AppBarConfiguration
import androidx.navigation.ui.setupActionBarWithNavController
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.votingworkshopapp.Models.ExhibitorWorkshop
import com.example.votingworkshopapp.Models.Notification
import com.example.votingworkshopapp.Utilities.AccountService
import com.example.votingworkshopapp.Utilities.WorkshopService
import com.example.votingworkshopapp.databinding.ActivityMainBinding
import org.json.JSONArray
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter
import java.util.Date

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private lateinit var toolbar: Toolbar
    private lateinit var notificationRecyclerView: RecyclerView
    private lateinit var notificationAdapter: NotificationAdapter
    private val notificationList = mutableListOf<Notification>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)

        setSupportActionBar(findViewById(R.id.toolbar))
        supportActionBar?.title = "Exhibitions App"
        supportActionBar?.setDisplayHomeAsUpEnabled(false)

        notificationRecyclerView = binding.notificationRecyclerView
        notificationRecyclerView.layoutManager = LinearLayoutManager(this)
        notificationAdapter = MainActivity.NotificationAdapter(notificationList)
        notificationRecyclerView.adapter = notificationAdapter
        AccountService.GetNotifications(this).execute()

        val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
        val userJSONString = sp.getString("user", null)
        if (sp.getString("user", null) != null) {
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            val username = userJSON["username"]
            binding.welcomeMessage.text = "Welcome $username"
            binding.welcomeMessage.visibility = View.VISIBLE
            binding.loginLogoutBtn.text = "Logout"
            binding.notificationContainer.visibility = View.VISIBLE
            binding.exhibitorHomeBtn.visibility = View.VISIBLE
        }
        else {
            binding.welcomeMessage.visibility = View.GONE
            binding.notificationContainer.visibility = View.GONE
            binding.exhibitorHomeBtn.visibility = View.GONE
        }

        binding.loginLogoutBtn.setOnClickListener(View.OnClickListener {
            if (sp.getString("user", null) != null) {
                sp.edit().remove("user").apply()
                binding.welcomeMessage.visibility = View.GONE
                binding.notificationContainer.visibility = View.GONE
                binding.loginLogoutBtn.text = "Login"
                binding.exhibitorHomeBtn.visibility = View.GONE
            }
            else {
                var intent = Intent(this, LoginActivity::class.java)
                startActivity(intent)
            }
        })

        binding.exhibitorHomeBtn.setOnClickListener(View.OnClickListener {
            var intent = Intent(this, ExhibitorHomeActivity::class.java)
            startActivity(intent)
        })
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        MenuInflater(this).inflate(R.menu.menu, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when (item.itemId) {
            android.R.id.home -> {
                val intent = Intent(this, MainActivity::class.java)
                startActivity(intent)
                true
            }
            else -> super.onOptionsItemSelected(item)
        }
    }

    fun displayNotifications(workshopsJSONString: String) {
        val workshops = JSONArray(workshopsJSONString)
        val notificationList = mutableListOf<Notification>()

        val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
        val userJSONString = sp.getString("user", null)
        val lastNotification = sp.getString("notification", LocalDateTime.now().toString())
        var userId = "0"
        if (sp.getString("user", null) != null) {
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            userId = userJSON["userId"].toString()
        }

        for (i in 0 until workshops.length()) {
            val jsonObject = workshops.getJSONObject(i)
            Log.d("Exhibitor Workshop", "Result: $jsonObject")
            val notification = Notification(
                "Date: ${LocalDateTime.parse(jsonObject.getString("lastUpdated")).format(
                    DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss"))}",
                "Your request (${jsonObject.getString("saloon")}) is now: ${jsonObject.getString("status")}"
            )
            if (jsonObject.getString("userId") == userId) {
                if (LocalDateTime.parse(jsonObject.getString("lastUpdated")) > LocalDateTime.parse(lastNotification)) {
                    notificationList.add(notification)
                }
            }
        }

        notificationList.sortBy { it.date }

        this.notificationList.addAll(notificationList)
        notificationAdapter.notifyDataSetChanged()

        sp.edit().putString("notification", LocalDateTime.now().toString()).apply()
    }

    class NotificationAdapter(private val list: List<Notification>) : RecyclerView.Adapter<NotificationAdapter.UserViewHolder>() {

        class UserViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
            val Date: TextView = itemView.findViewById(R.id.date)
            val Message: TextView = itemView.findViewById(R.id.message)
        }

        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): UserViewHolder {
            val itemView = LayoutInflater.from(parent.context).inflate(R.layout.notification_row, parent, false)
            return UserViewHolder(itemView)
        }

        override fun onBindViewHolder(holder: UserViewHolder, position: Int) {
            val currentItem = list[position]
            holder.Date.text = currentItem.date
            holder.Message.text = currentItem.message
        }

        override fun getItemCount() = list.size
    }
}