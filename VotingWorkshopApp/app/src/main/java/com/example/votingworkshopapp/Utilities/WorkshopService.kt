package com.example.votingworkshopapp.Utilities

import android.os.AsyncTask
import android.util.Log
import com.example.votingworkshopapp.ExhibitorHomeActivity
import com.example.votingworkshopapp.MainActivity
import com.example.votingworkshopapp.Models.WorkshopRequest
import com.example.votingworkshopapp.NewWorkshopActivity
import kotlinx.serialization.encodeToString
import kotlinx.serialization.json.Json
import java.io.BufferedReader
import java.io.InputStreamReader
import java.io.OutputStream
import java.net.HttpURLConnection
import java.net.URL

class WorkshopService {
    class GetWorkshopOptions(private var context: NewWorkshopActivity) : AsyncTask<Void, Void, Boolean>() {
        private var optionsJSONString = "";

        override fun doInBackground(vararg params: Void?): Boolean {
            val url = URL("http://10.0.2.2:5063/api/workshop/options")
            val con: HttpURLConnection = url.openConnection() as HttpURLConnection
            con.setRequestProperty("Accept", "application/json");
            Log.d("Http Service Tag-post", "response code "+con.responseCode);

            if (con.responseCode == 200) {
                val reader = BufferedReader(InputStreamReader(con.inputStream))
                val result = reader.readLines().joinToString()
                Log.d("Http Service Tag-post", "HTTP result: $result")

                optionsJSONString = result
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
                context.setupOptions(optionsJSONString)
            }
        }
    }

    class RequestNewWorkshop(private var context: NewWorkshopActivity, private var workshopRequest: WorkshopRequest) : AsyncTask<Void, Void, Boolean>() {
        override fun doInBackground(vararg params: Void?): Boolean {
            val url = URL("http://10.0.2.2:5063/api/workshop/new")
            val con: HttpURLConnection = url.openConnection() as HttpURLConnection
            con.requestMethod = "POST"
            con.setRequestProperty("Content-Type", "application/json; utf-8");
            con.setRequestProperty("Accept", "application/json");
            val json = Json.encodeToString(workshopRequest)
            val outStream: OutputStream = con.outputStream
            outStream.write(json.toByteArray())
            outStream.flush()
            outStream.close()
            Log.d("Http Service Tag-post", "response code "+con.responseCode);

            if (con.responseCode == 200) {
                val reader = BufferedReader(InputStreamReader(con.inputStream))
                val result = reader.readLines()
                Log.d("Http Service Tag-post", "HTTP result: $result")
            }

            con.disconnect();
            return con.responseCode == 200
        }

        override fun onPreExecute() {
            super.onPreExecute()
            context.onRequestWorkshopTrying();
        }

        override fun onPostExecute(result: Boolean) {
            super.onPostExecute(result)
            if(result)
            {
                context.onRequestWorkshopCompleted();
            }
            else
            {
                context.onRequestWorkshopError();
            }
        }
    }

    class GetMyWorkshops(private var context: ExhibitorHomeActivity) : AsyncTask<Void, Void, Boolean>() {
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
                context.displayMyWorkshops(workshopsJSONString)
            }
        }
    }

    class GetRecentworkshops(private var context: MainActivity) : AsyncTask<Void, Void, Boolean>() {
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
                context.displayRecentworkshops(workshopsJSONString)
            }
        }
    }
}