Feature: Context
	In order to be able to manage player state
	As a user
	I want to be told the HP of the player

@hp
Scenario: HP after fight
	Given I have player with 100 HP
	When a monster with strength of 10 attack him
	Then player HP should be 90 HP