package com.example.votingworkshopapp

import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity
import com.example.votingworkshopapp.Models.LoginRequest
import com.example.votingworkshopapp.Utilities.AccountService
import com.example.votingworkshopapp.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)

        binding.loginBtn.setOnClickListener(View.OnClickListener {
            val loginRequest = LoginRequest()
            loginRequest.Username = binding.username.toString()
            loginRequest.Password = binding.password.toString()
            AccountService.Login(this, loginRequest).execute()
        })
    }

    public fun onLoginTrying() {
        binding.loginBtn.text = "Logging in..."
    }

    public fun onLoginCompleted() {
        binding.loginBtn.text = "Logged in!"
    }

    public fun onLoginError() {
        binding.loginBtn.text = "Login Error!"
    }
}