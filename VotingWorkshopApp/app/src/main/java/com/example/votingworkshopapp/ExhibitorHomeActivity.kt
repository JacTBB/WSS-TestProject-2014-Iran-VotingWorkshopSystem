package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.os.RemoteCallbackList
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
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.votingworkshopapp.Models.ExhibitorWorkshop
import com.example.votingworkshopapp.Utilities.WorkshopService
import com.example.votingworkshopapp.databinding.ActivityExhibitorHomeBinding
import org.json.JSONArray
import org.json.JSONObject
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.format.DateTimeFormatter
import java.util.Date

class ExhibitorHomeActivity : AppCompatActivity() {
    private lateinit var binding: ActivityExhibitorHomeBinding

    private lateinit var workshopRecyclerView: RecyclerView
    private lateinit var workshopAdapter: ExhibitorWorkshopAdapter
    private val workshopList = mutableListOf<ExhibitorWorkshop>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityExhibitorHomeBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val view = binding.root
        setContentView(view)

        setSupportActionBar(findViewById(R.id.toolbar))
        supportActionBar?.title = "Login"
        supportActionBar?.setDisplayHomeAsUpEnabled(true)

        workshopRecyclerView = binding.workshopRecyclerView
        workshopRecyclerView.layoutManager = LinearLayoutManager(this)
        workshopAdapter = ExhibitorWorkshopAdapter(workshopList)
        workshopRecyclerView.adapter = workshopAdapter
        WorkshopService.GetMyWorkshops(this).execute()

        binding.newWorkshopBtn.setOnClickListener(View.OnClickListener {
            var intent = Intent(this, NewWorkshopActivity::class.java)
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

    fun displayMyWorkshops(workshopsJSONString: String) {
        val workshops = JSONArray(workshopsJSONString)
        val workshopList = mutableListOf<ExhibitorWorkshop>()

        val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
        val userJSONString = sp.getString("user", null)
        var userId = "0"
        if (sp.getString("user", null) != null) {
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            userId = userJSON["userId"].toString()
        }

        for (i in 0 until workshops.length()) {
            val jsonObject = workshops.getJSONObject(i)
            Log.d("Exhibitor Workshop", "Result: $jsonObject")

            val timeslotStart = LocalTime.parse(jsonObject.getString("timeslotStart")).format(DateTimeFormatter.ofPattern("HH:mm"))
            val timeslotEnd = LocalTime.parse(jsonObject.getString("timeslotEnd")).format(DateTimeFormatter.ofPattern("HH:mm"))

            val workshop = ExhibitorWorkshop(
                jsonObject.getString("workshopRequestId"),
                jsonObject.getString("saloon"),
                jsonObject.getString("category"),
                LocalDateTime.parse(jsonObject.getString("date")).format(DateTimeFormatter.ofPattern("dd-MM-yyyy")),
                "$timeslotStart - $timeslotEnd",
                jsonObject.getString("status")
            )
            if (jsonObject.getString("userId") == userId) {
                workshopList.add(workshop)
            }
        }

        val statusOrder = listOf("Pending", "Accepted", "Rejected")
        workshopList.sortWith(compareBy<ExhibitorWorkshop> { statusOrder.indexOf(it.Status) }
            .thenByDescending { it.Date })

        workshopList.add(0, ExhibitorWorkshop("ID", "Saloon", "Category", "Date", "Timeslot", "Status"))

        this.workshopList.addAll(workshopList)
        workshopAdapter.notifyDataSetChanged()
    }

    class ExhibitorWorkshopAdapter(private val userList: List<ExhibitorWorkshop>) : RecyclerView.Adapter<ExhibitorWorkshopAdapter.UserViewHolder>() {

        class UserViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
            val textViewId: TextView = itemView.findViewById(R.id.id)
            val textViewSaloon: TextView = itemView.findViewById(R.id.saloon)
            val textViewCategory: TextView = itemView.findViewById(R.id.category)
            val Date: TextView = itemView.findViewById(R.id.date)
            val Timeslot: TextView = itemView.findViewById(R.id.timeslot)
            val Status: TextView = itemView.findViewById(R.id.status)
        }

        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): UserViewHolder {
            val itemView = LayoutInflater.from(parent.context).inflate(R.layout.workshop_exhibitor_row, parent, false)
            return UserViewHolder(itemView)
        }

        override fun onBindViewHolder(holder: UserViewHolder, position: Int) {
            val currentItem = userList[position]
            holder.textViewId.text = currentItem.id
            holder.textViewSaloon.text = currentItem.Saloon
            holder.textViewCategory.text = currentItem.Category
            holder.Date.text = currentItem.Date
            holder.Timeslot.text = currentItem.Timeslot
            holder.Status.text = currentItem.Status
        }

        override fun getItemCount() = userList.size
    }
}