package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
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

        setSupportActionBar(findViewById(R.id.toolbar))
        supportActionBar?.title = "Login"
        supportActionBar?.setDisplayHomeAsUpEnabled(true)

        binding.loginBtn.setOnClickListener(View.OnClickListener {
            val loginRequest = LoginRequest()
            loginRequest.Username = binding.username.text.toString()
            loginRequest.Password = binding.password.text.toString()
            AccountService.Login(this, loginRequest).execute()
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

    public fun onLoginTrying() {
        binding.loginBtn.isEnabled = false
        binding.loginBtn.text = "Logging in..."
    }

    public fun onLoginCompleted() {
        binding.loginBtn.isEnabled = true
        binding.loginBtn.text = "Login"
        Toast.makeText(this,"Logged in successfully", Toast.LENGTH_SHORT).show()
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    public fun onLoginError() {
        binding.loginBtn.isEnabled = true
        binding.loginBtn.text = "Login"
        Toast.makeText(this,"Incorrect username or password", Toast.LENGTH_SHORT).show()
    }
}