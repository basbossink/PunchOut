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
module PunchOutTest.``Tests for the PunchOut module``

open Xunit
open FsUnit.Xunit
open PunchOut.PunchOut

[<Fact>]
let ``When hours worked is equal to the target should get start time`` () =
    punchOut "7:30" 37.0 37.0 |> should equal "7:30"


[<Fact>]
let ``When hours worked is an hour short of the target should return an hour past starting time`` () =
    punchOut "7:30" 37.0 36.0 |> should equal "8:30"