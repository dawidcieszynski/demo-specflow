Feature: Scenario Outline
	In order to be able to manage player state
	As a user
	I want to be told the HP of the player

@hp
Scenario Outline: HP after fight
	Given I have player with <hp> HP
	When a monster with strength of <monster strength> attack him
	Then player HP should be <expected hp> HP
	 
Examples: 
	| hp | monster strength | expected hp |
	| 75 | 50               | 25          |
	| 50 | 50               | 0           |
	| 20 | 50               | 0           |
