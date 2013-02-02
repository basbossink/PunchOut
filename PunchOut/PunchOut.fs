namespace PunchOut

module PunchOut =

    open System
    open System.Globalization

    let punchOut start target worked = 
        let format = new DateTimeFormatInfo()
        format.ShortTimePattern <- "H:m"
        let startTime = DateTime.Parse(start, format , DateTimeStyles.AssumeLocal ||| DateTimeStyles.AllowWhiteSpaces)
        let targetSpan = TimeSpan.FromHours(target)
        let workedSpan = TimeSpan.FromHours(worked)
        (startTime + (targetSpan - workedSpan)).ToString("H:m")

        
