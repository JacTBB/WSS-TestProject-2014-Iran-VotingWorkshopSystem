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
import android.widget.LinearLayout
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.appcompat.widget.Toolbar
import androidx.navigation.findNavController
import androidx.navigation.ui.AppBarConfiguration
import androidx.navigation.ui.setupActionBarWithNavController
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.votingworkshopapp.Models.CalendarItem
import com.example.votingworkshopapp.Models.ExhibitorWorkshop
import com.example.votingworkshopapp.Models.Notification
import com.example.votingworkshopapp.Models.Workshop
import com.example.votingworkshopapp.Utilities.AccountService
import com.example.votingworkshopapp.Utilities.WorkshopService
import com.example.votingworkshopapp.databinding.ActivityMainBinding
import org.json.JSONArray
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.ZoneId
import java.time.ZoneOffset
import java.time.ZonedDateTime
import java.time.format.DateTimeFormatter
import java.util.Date
import java.util.Locale.Category

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    private lateinit var ongoingRecyclerView: RecyclerView
    private lateinit var ongoingAdapter: OngoingAdapter
    private val ongoingList = mutableListOf<Workshop>()

    private var scheduleDate = LocalDateTime.now().format(DateTimeFormatter.ofPattern("dd-MM-yyyy"))
    private var scheduleDateAdder = 0.toLong()
    private lateinit var scheduleRecyclerView: RecyclerView
    private lateinit var scheduleAdapter: ScheduleAdapter
    private val scheduleList = mutableListOf<Workshop>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)

        setSupportActionBar(findViewById(R.id.toolbar))
        supportActionBar?.setDisplayHomeAsUpEnabled(false)
        supportActionBar?.title = "WorldSkills Exhibition 2024"

        ongoingRecyclerView = binding.ongoingRecyclerView
        ongoingRecyclerView.layoutManager = LinearLayoutManager(this)
        ongoingAdapter = OngoingAdapter(ongoingList)
        ongoingRecyclerView.adapter = ongoingAdapter
        WorkshopService.GetOngoingWorkshops(this).execute()

        scheduleRecyclerView = binding.scheduleRecyclerView
        scheduleRecyclerView.layoutManager = LinearLayoutManager(this)
        scheduleAdapter = ScheduleAdapter(scheduleList)
        scheduleRecyclerView.adapter = scheduleAdapter
        WorkshopService.GetWorkshopsSchedule(this).execute()
        binding.scheduleText.text = scheduleDate

        val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
        val userJSONString = sp.getString("user", null)
        if (sp.getString("user", null) != null) {
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            val username = userJSON["username"]
            binding.welcomeMessage.text = "Welcome $username"
            binding.welcomeMessage.visibility = View.VISIBLE
            binding.loginLogoutBtn.text = "Logout"
            binding.exhibitorHomeBtn.visibility = View.VISIBLE
        }
        else {
            binding.welcomeMessage.visibility = View.GONE
            binding.exhibitorHomeBtn.visibility = View.GONE
        }

        binding.loginLogoutBtn.setOnClickListener(View.OnClickListener {
            if (sp.getString("user", null) != null) {
                sp.edit().remove("user").apply()
                binding.welcomeMessage.visibility = View.GONE
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

        binding.nextBtn.setOnClickListener(View.OnClickListener {
            scheduleDateAdder++
            val date = LocalDateTime.now().plusDays(scheduleDateAdder).format(DateTimeFormatter.ofPattern("dd-MM-yyyy"))
            scheduleDate = date
            binding.scheduleText.text = scheduleDate
            WorkshopService.GetWorkshopsSchedule(this).execute()
        })

        binding.previousBtn.setOnClickListener(View.OnClickListener {
            scheduleDateAdder--
            val date = LocalDateTime.now().plusDays(scheduleDateAdder).format(DateTimeFormatter.ofPattern("dd-MM-yyyy"))
            scheduleDate = date
            binding.scheduleText.text = scheduleDate
            WorkshopService.GetWorkshopsSchedule(this).execute()
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

    fun displayOngoingWorkshops(workshopsJSONString: String) {
        val workshops = JSONArray(workshopsJSONString)
        val ongoingList = mutableListOf<Workshop>()

        for (i in 0 until workshops.length()) {
            val jsonObject = workshops.getJSONObject(i)

            val timeslotStart = LocalTime.parse(jsonObject.getString("timeslotStart")).format(DateTimeFormatter.ofPattern("HH:mm"))
            val timeslotEnd = LocalTime.parse(jsonObject.getString("timeslotEnd")).format(DateTimeFormatter.ofPattern("HH:mm"))

            val workshop = Workshop(
                jsonObject.getString("workshopRequestId"),
                jsonObject.getString("saloon"),
                jsonObject.getString("category"),
                LocalDateTime.parse(jsonObject.getString("date")).format(DateTimeFormatter.ofPattern("dd-MM-yyyy")),
                "$timeslotStart - $timeslotEnd"
            )
            if (jsonObject.getString("status").equals("Accepted")) {
                if (workshop.Date == LocalDateTime.now().format(DateTimeFormatter.ofPattern("dd-MM-yyyy"))) {
                    Log.d("Ongoing Workshop", "${timeslotStart} ${timeslotEnd} ${ZonedDateTime.now(ZoneId.of("Asia/Singapore")).format(DateTimeFormatter.ofPattern("HH:mm"))}")
                    if (timeslotStart < ZonedDateTime.now(ZoneId.of("Asia/Singapore")).format(DateTimeFormatter.ofPattern("HH:mm")) &&
                        timeslotEnd > ZonedDateTime.now(ZoneId.of("Asia/Singapore")).format(DateTimeFormatter.ofPattern("HH:mm"))) {
                        ongoingList.add(workshop)
                    }
                }
            }
        }

        ongoingList.sortBy { it.Date }

        this.ongoingList.clear()
        this.ongoingList.addAll(ongoingList)
        ongoingAdapter.notifyDataSetChanged()
    }

    class OngoingAdapter(private val list: List<Workshop>) : RecyclerView.Adapter<OngoingAdapter.UserViewHolder>() {
        class UserViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
            val Saloon: TextView = itemView.findViewById(R.id.saloon)
            val Category: TextView = itemView.findViewById(R.id.category)
            val Timeslot: TextView = itemView.findViewById(R.id.timeslot)
        }

        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): UserViewHolder {
            val itemView = LayoutInflater.from(parent.context).inflate(R.layout.workshop_row, parent, false)
            return UserViewHolder(itemView)
        }

        override fun onBindViewHolder(holder: UserViewHolder, position: Int) {
            val currentItem = list[position]
            holder.Saloon.text = currentItem.Saloon
            holder.Category.text = currentItem.Category
            holder.Timeslot.text = currentItem.Timeslot
        }

        override fun getItemCount() = list.size
    }

    fun displayWorkshopsSchedule(workshopsJSONString: String) {
        val workshops = JSONArray(workshopsJSONString)
        val scheduleList = mutableListOf<Workshop>()

        for (i in 0 until workshops.length()) {
            val jsonObject = workshops.getJSONObject(i)

            val timeslotStart = LocalTime.parse(jsonObject.getString("timeslotStart")).format(DateTimeFormatter.ofPattern("HH:mm"))
            val timeslotEnd = LocalTime.parse(jsonObject.getString("timeslotEnd")).format(DateTimeFormatter.ofPattern("HH:mm"))

            val workshop = Workshop(
                jsonObject.getString("workshopRequestId"),
                jsonObject.getString("saloon"),
                jsonObject.getString("category"),
                LocalDateTime.parse(jsonObject.getString("date")).format(DateTimeFormatter.ofPattern("dd-MM-yyyy")),
                "$timeslotStart - $timeslotEnd"
            )
            if (jsonObject.getString("status").equals("Accepted")) {
                if (workshop.Date == scheduleDate) {
                    scheduleList.add(workshop)
                }
            }
        }

        scheduleList.sortBy { it.Date }

        scheduleList.add(0, Workshop("ID", "Saloon", "Category", "Date", "Timeslot"))

        this.scheduleList.clear()
        this.scheduleList.addAll(scheduleList)
        scheduleAdapter.notifyDataSetChanged()
    }

    class ScheduleAdapter(private val list: List<Workshop>) : RecyclerView.Adapter<ScheduleAdapter.UserViewHolder>() {
        class UserViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
            val Saloon: TextView = itemView.findViewById(R.id.saloon)
            val Category: TextView = itemView.findViewById(R.id.category)
            val Timeslot: TextView = itemView.findViewById(R.id.timeslot)
        }

        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): UserViewHolder {
            val itemView = LayoutInflater.from(parent.context).inflate(R.layout.workshop_row, parent, false)
            return UserViewHolder(itemView)
        }

        override fun onBindViewHolder(holder: UserViewHolder, position: Int) {
            val currentItem = list[position]
            holder.Saloon.text = currentItem.Saloon
            holder.Category.text = currentItem.Category
            holder.Timeslot.text = currentItem.Timeslot
        }

        override fun getItemCount() = list.size
    }
}