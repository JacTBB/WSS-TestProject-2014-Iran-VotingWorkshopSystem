package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.example.votingworkshopapp.Models.LoginRequest
import com.example.votingworkshopapp.Utilities.AccountService
import com.example.votingworkshopapp.databinding.ActivityLoginBinding

class LoginActivity : AppCompatActivity() {
    private lateinit var binding: ActivityLoginBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val view = binding.root
        setContentView(view)

        binding.backBtn.setOnClickListener{
            val intent = Intent(this, MainActivity::class.java)
            startActivity(intent)
        }

        binding.loginBtn.setOnClickListener(View.OnClickListener {
            val loginRequest = LoginRequest()
            loginRequest.Username = binding.username.text.toString()
            loginRequest.Password = binding.password.text.toString()
            AccountService.Login(this, loginRequest).execute()
        })
    }

    public fun onLoginTrying() {
        binding.loginBtn.isEnabled = false
        binding.loginBtn.text = "Logging in..."
    }

    public fun onLoginCompleted() {
        binding.loginBtn.isEnabled = true
        binding.loginBtn.text = "Login"
        Toast.makeText(this,"Logged in successfully", Toast.LENGTH_SHORT).show()
    }

    public fun onLoginError() {
        binding.loginBtn.isEnabled = true
        binding.loginBtn.text = "Login"
        Toast.makeText(this,"Incorrect username or password", Toast.LENGTH_SHORT).show()
    }
}