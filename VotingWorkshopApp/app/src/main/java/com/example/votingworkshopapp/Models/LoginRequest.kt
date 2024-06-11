package com.example.votingworkshopapp.Models

import kotlinx.serialization.Serializable

@Serializable
class LoginRequest {
    var Username: String = ""
    var Password: String = ""
}