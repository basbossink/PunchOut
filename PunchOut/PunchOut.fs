// This file is part of PunchOut.
//
// PunchOut is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// PunchOut is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with PunchOut.  If not, see <http://www.gnu.org/licenses/>.
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

        
