package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.preference.PreferenceManager
import android.view.View
import androidx.appcompat.app.AppCompatActivity
import com.example.votingworkshopapp.databinding.ActivityMainBinding
import org.json.JSONArray

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)

        binding.welcomeMessage.text = "Please login:"
        val sp = PreferenceManager.getDefaultSharedPreferences(applicationContext)
        val userJSONString = sp.getString("user", null)
        if (sp.getString("user", null) != null) {
            val userJSON = JSONArray(userJSONString).getJSONObject(0)
            val username = userJSON["username"]
            binding.welcomeMessage.text = "Welcome $username"
            binding.loginLogoutBtn.text = "Logout"
            binding.newWorkshopBtn.isEnabled = true
        }
        else {
            binding.newWorkshopBtn.isEnabled = false
        }

        binding.loginLogoutBtn.setOnClickListener(View.OnClickListener {
            if (sp.getString("user", null) != null) {
                sp.edit().remove("user").apply()
                binding.welcomeMessage.text = "Please login:"
                binding.loginLogoutBtn.text = "Login"
                binding.newWorkshopBtn.isEnabled = false
            }
            else {
                var intent = Intent(this, LoginActivity::class.java)
                startActivity(intent)
            }
        })

        binding.newWorkshopBtn.setOnClickListener(View.OnClickListener {
            var intent = Intent(this, NewWorkshopActivity::class.java)
            startActivity(intent)
        })
    }
}