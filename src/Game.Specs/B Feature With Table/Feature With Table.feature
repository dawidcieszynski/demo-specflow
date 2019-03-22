Feature: Feature With Table
	In order to be able to manage player state
	As a user
	I want to be told the HP of the player

@hp
Scenario: HP after fight with multiple monsters
	Given I have player with 100 HP
	When folowing monsters attack him
			| Name     | Strength |
			| monster1 | 25       |
			| monster2 | 50       |
	Then player HP should be 25 HP
