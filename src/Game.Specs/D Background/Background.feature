Feature: Background
	In order to be able to manage player state
	As a user
	I want to be told the HP of the player

Background: 
	Given I have player with 50 HP

@hp
Scenario: HP after fight
	When a monster with strength of 10 attack him
	Then player HP should be 40 HP
	
@hp
Scenario: HP after healing
	When player use a Health Potion
	Then player HP should be 100 HP

@hp
Scenario: HP after healing multiple times
	When player use a Health Potion
	When player use a Health Potion
	And player use a Health Potion
	Then player HP should be 100 HP