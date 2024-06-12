package com.example.votingworkshopapp.Utilities

import android.os.AsyncTask
import android.preference.PreferenceManager
import android.util.Log
import com.example.votingworkshopapp.ExhibitorHomeActivity
import com.example.votingworkshopapp.LoginActivity
import com.example.votingworkshopapp.MainActivity
import com.example.votingworkshopapp.Models.LoginRequest
import kotlinx.serialization.encodeToString
import kotlinx.serialization.json.Json
import java.io.BufferedReader
import java.io.InputStreamReader
import java.io.OutputStream
import java.net.HttpURLConnection
import java.net.URL

class AccountService {
    class Login(private var context: LoginActivity, private var loginRequest: LoginRequest) : AsyncTask<Void, Void, Boolean>() {
        override fun doInBackground(vararg params: Void?): Boolean {
            val url = URL("http://10.0.2.2:5063/api/account/login")
            val con: HttpURLConnection = url.openConnection() as HttpURLConnection
            con.requestMethod = "POST"
            con.setRequestProperty("Content-Type", "application/json; utf-8");
            con.setRequestProperty("Accept", "application/json");
            val json = Json.encodeToString(loginRequest)
            val outStream: OutputStream = con.outputStream
            outStream.write(json.toByteArray())
            outStream.flush()
            outStream.close()
            Log.d("Http Service Tag-post", "response code "+con.responseCode);

            if (con.responseCode == 200) {
                val reader = BufferedReader(InputStreamReader(con.inputStream))
                val result = reader.readLines()
                Log.d("Http Service Tag-post", "HTTP result: $result")

                val sp = PreferenceManager.getDefaultSharedPreferences(context.applicationContext)
                val edit = sp.edit()
                edit.putString("user", result.toString())
                edit.commit()
            }

            con.disconnect();
            return con.responseCode == 200
        }

        override fun onPreExecute() {
            super.onPreExecute()
            context.onLoginTrying();
        }

        override fun onPostExecute(result: Boolean) {
            super.onPostExecute(result)
            if(result)
            {
                context.onLoginCompleted();
            }
            else
            {
                context.onLoginError();
            }
        }
    }

    class GetNotifications(private var context: MainActivity) : AsyncTask<Void, Void, Boolean>() {
        private var workshopsJSONString = "";

        override fun doInBackground(vararg params: Void?): Boolean {
            val url = URL("http://10.0.2.2:5063/api/workshop")
            val con: HttpURLConnection = url.openConnection() as HttpURLConnection
            con.setRequestProperty("Accept", "application/json");
            Log.d("Http Service Tag-post", "response code " + con.responseCode);

            if (con.responseCode == 200) {
                val reader = BufferedReader(InputStreamReader(con.inputStream))
                val result = reader.readLines().joinToString()
                Log.d("Http Service Tag-post", "HTTP result: $result")

                workshopsJSONString = result
            }

            con.disconnect();
            return con.responseCode == 200
        }

        override fun onPreExecute() {
            super.onPreExecute()
        }

        override fun onPostExecute(result: Boolean) {
            super.onPostExecute(result)
            if (result) {
                context.displayNotifications(workshopsJSONString)
            }
        }
    }
}