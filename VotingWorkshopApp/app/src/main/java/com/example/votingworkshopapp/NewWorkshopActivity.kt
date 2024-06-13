package com.example.votingworkshopapp

import android.R
import android.app.DatePickerDialog
import android.app.DatePickerDialog.OnDateSetListener
import android.content.Intent
import android.os.Bundle
import android.preference.PreferenceManager
import android.util.Log
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.example.votingworkshopapp.Models.WorkshopRequest
import com.example.votingworkshopapp.Utilities.WorkshopService
import com.example.votingworkshopapp.databinding.ActivityNewWorkshopBinding
import org.json.JSONArray
import org.json.JSONObject
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale


class NewWorkshopActivity : AppCompatActivity() {
    private lateinit var binding: ActivityNewWorkshopBinding

    var saloons = JSONArray();
    var categories = JSONArray();
    var workshopTimeslots = JSONArray();

    var selectedDate: Date? = null
    var datePickerDialog: DatePickerDialog? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityNewWorkshopBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val view = binding.root
        setContentView(view)

        setSupportActionBar(findViewById(com.example.votingworkshopapp.R.id.toolbar))
        supportActionBar?.title = "New Workshop Request"
        supportActionBar?.setDisplayHomeAsUpEnabled(true)

        WorkshopService.GetWorkshopOptions(this).execute()

        setupDatePicker()
        binding.datePickerBtn.setOnClickListener {
            datePickerDialog!!.show()
        }

        binding.requestWorkshopBtn.setOnClickListener {
            val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
            val userJSONString = sp.getString("user", null)
            if (userJSONString == null) {
                return@setOnClickListener Toast.makeText(this,"Invalid User", Toast.LENGTH_SHORT).show()
            }
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            val userId = userJSON["userId"]
            val statusId = 3 // Pending

            var saloonId = 0;
            for (i in 0 until saloons.length()) {
                val jsonObject = saloons.getJSONObject(i)
                if (jsonObject.getString("saloonName") == binding.saloon.selectedItem.toString()) {
                    saloonId = jsonObject.getInt("saloonId")
                }
            }

            var categoryId = 0;
            for (i in 0 until categories.length()) {
                val jsonObject = categories.getJSONObject(i)
                if (jsonObject.getString("categoryName") == binding.category.selectedItem.toString()) {
                    categoryId = jsonObject.getInt("categoryId")
                }
            }

            var workshopTimeslotId = 0;
            for (i in 0 until workshopTimeslots.length()) {
                val jsonObject = workshopTimeslots.getJSONObject(i)
                val item1 = jsonObject.getString("startTime")
                val item2 = jsonObject.getString("endTime")
                if ("$item1 - $item2" == binding.timeslot.selectedItem.toString()) {
                    workshopTimeslotId = jsonObject.getInt("workshopTimeslotId")
                }
            }

            if (userId == 0) {
                return@setOnClickListener Toast.makeText(this,"Invalid User", Toast.LENGTH_SHORT).show()
            }
            if (saloonId == 0) {
                return@setOnClickListener Toast.makeText(this,"Invalid Saloon", Toast.LENGTH_SHORT).show()
            }
            if (categoryId == 0) {
                return@setOnClickListener Toast.makeText(this,"Invalid Category", Toast.LENGTH_SHORT).show()
            }
            if (workshopTimeslotId == 0) {
                return@setOnClickListener Toast.makeText(this,"Invalid Timeslot", Toast.LENGTH_SHORT).show()
            }
            if (selectedDate == null) {
                return@setOnClickListener Toast.makeText(this,"Invalid Date", Toast.LENGTH_SHORT).show()
            }

            Log.d("Workshop Request", userId.toString());
            Log.d("Workshop Request", saloonId.toString());
            Log.d("Workshop Request", categoryId.toString());
            Log.d("Workshop Request", workshopTimeslotId.toString());
            Log.d("Workshop Request", statusId.toString());
            Log.d("Workshop Request", selectedDate.toString());

            val workshopRequest = WorkshopRequest()
            workshopRequest.UserId = userId.toString()
            workshopRequest.SaloonId = saloonId.toString()
            workshopRequest.CategoryId = categoryId.toString()
            workshopRequest.WorkshopTimeslotId = workshopTimeslotId.toString()
            workshopRequest.StatusId = statusId.toString()
            workshopRequest.Date = SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss'Z'", Locale.US).format(selectedDate)

            WorkshopService.RequestNewWorkshop(this, workshopRequest).execute()
        }
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        MenuInflater(this).inflate(com.example.votingworkshopapp.R.menu.menu, menu)
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

    private fun setupDatePicker() {
        val dateSetListener = OnDateSetListener { datePicker, year, month, day ->
            selectedDate = Date(year - 1900, month, day)
            binding.datePickerBtn.text = "Selected Date: $day/${month + 1}/$year"
        }

        val calendar = Calendar.getInstance()
        val year = calendar.get(Calendar.YEAR)
        val month = calendar.get(Calendar.MONTH)
        val day = calendar.get(Calendar.DAY_OF_MONTH)

        datePickerDialog = DatePickerDialog(this, dateSetListener, year, month, day)
    }

    fun setupOptions(optionsJSONString: String) {
        val optionsJSON = JSONObject(optionsJSONString)
        saloons = optionsJSON.getJSONArray("saloons")
        categories = optionsJSON.getJSONArray("categories")
        workshopTimeslots = optionsJSON.getJSONArray("workshopTimeslots")
        val saloonItems = mutableListOf<String>()
        val categoryItems = mutableListOf<String>()
        val workshopTimeslotItems = mutableListOf<String>()

        for (i in 0 until saloons.length()) {
            val jsonObject = saloons.getJSONObject(i)
            val item = jsonObject.getString("saloonName")
            saloonItems.add(item)
        }

        for (i in 0 until categories.length()) {
            val jsonObject = categories.getJSONObject(i)
            val item = jsonObject.getString("categoryName")
            categoryItems.add(item)
        }

        for (i in 0 until workshopTimeslots.length()) {
            val jsonObject = workshopTimeslots.getJSONObject(i)
            val item1 = jsonObject.getString("startTime")
            val item2 = jsonObject.getString("endTime")
            workshopTimeslotItems.add("$item1 - $item2")
        }

        binding.saloon.adapter = ArrayAdapter(
            this,
            R.layout.simple_spinner_item,
            saloonItems
        ).also { it.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item) }

        binding.category.adapter = ArrayAdapter(
            this,
            R.layout.simple_spinner_item,
            categoryItems
        ).also { it.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item) }

        binding.timeslot.adapter = ArrayAdapter(
            this,
            R.layout.simple_spinner_item,
            workshopTimeslotItems
        ).also { it.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item) }
    }

    public fun onRequestWorkshopTrying() {
        binding.requestWorkshopBtn.isEnabled = false
        binding.requestWorkshopBtn.text = "Sending..."
    }

    public fun onRequestWorkshopCompleted() {
        binding.requestWorkshopBtn.isEnabled = true
        binding.requestWorkshopBtn.text = "Request Workshop"
        Toast.makeText(this,"Workshop Request Successfull", Toast.LENGTH_SHORT).show()
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    public fun onRequestWorkshopError() {
        binding.requestWorkshopBtn.isEnabled = true
        binding.requestWorkshopBtn.text = "Request Workshop"
        Toast.makeText(this,"Error requesting new workshop", Toast.LENGTH_SHORT).show()
    }
}