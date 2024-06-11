package com.example.votingworkshopapp.Models

import kotlinx.serialization.Serializable

@Serializable
class WorkshopRequest {
    var UserId: String = ""
    var SaloonId: String = ""
    var CategoryId: String = ""
    var WorkshopTimeslotId: String = ""
    var StatusId: String = ""
    var Date: String = ""
}