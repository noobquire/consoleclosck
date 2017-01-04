# consoleclosck
Team Fortress 2 console clock app

Allows you to see time in any Source Engine game in your console.
This is mostly useless app that demonstrates the possbiilities of external Source config generators.
To run the clock, simply download the app, copy it to your game cfg folder and run it.
In-game, be sure that you are on a server that has sv_allow_wait_command set to 1.
Then, type the following in your console:
alias timeloopback "exec time; clear; currenttime; wait 66; timeloopback"; timeloopback
To stop the clock, type:
alias timeloopback ""
