# Game Library & Player Stats Manager

This is my C# console application for CET2007 Assignment. I chose Scenario 1, which is the Game Library and Player Stats Manager.

This program lets the user store player details and game stats. Each player has an ID, username, hours played and high score.

## Features

- Add a player
- View all players
- Update player stats
- Search for a player by ID
- Search for a player by username
- Show top scores
- Show most active players
- Save and load data with JSON
- Write actions to a text log file
- Basic input validation
- Unit tests

## How to run

Open the solution in Visual Studio and run the `CET2007_GameStats` project.

The menu appears in the console. Type the number for the option you want to use.

## Files used

The program creates two main files when it runs:

- `players.json` stores the player data
- `log.txt` stores a basic record of actions

## Testing

I added an xUnit test project called `CET2007_GameStats.Tests`.

The tests check adding players, searching players, updating stats and sorting players.

## Design

The `Player` class stores the player data.

The `PlayerManager` class contains player management methods that are used for testing.

The program uses a `List<Player>` to store the players while the program is running.

Search is done using the player ID or username. Sorting is used for the top score and most active player reports.