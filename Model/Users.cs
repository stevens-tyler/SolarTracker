﻿namespace SolarTracker.Model;

public class Users {

    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string System { get; set; }
    public double CurrentPower { get; set; }
    public string CurrentTime { get; set; }
    public List<double> Day { get; set; }

}

