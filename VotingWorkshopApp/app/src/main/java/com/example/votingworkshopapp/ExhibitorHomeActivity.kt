package com.example.votingworkshopapp

import android.content.Intent
import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity
import com.example.votingworkshopapp.databinding.ActivityExhibitorHomeBinding

class ExhibitorHomeActivity : AppCompatActivity() {
    private lateinit var binding: ActivityExhibitorHomeBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityExhibitorHomeBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val view = binding.root
        setContentView(view)

        binding.backBtn.setOnClickListener{
            val intent = Intent(this, MainActivity::class.java)
            startActivity(intent)
        }

        binding.newWorkshopBtn.setOnClickListener(View.OnClickListener {
            var intent = Intent(this, NewWorkshopActivity::class.java)
            startActivity(intent)
        })
    }
}