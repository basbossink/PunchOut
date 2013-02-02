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