Feature: Boards
	In order to use Trello functionality 
	As a user
	I want to have possibility to create a new bord
	
  @Boards
  Scenario Outline: Create board success
    When I create board with name <name>
    Then I should get successful response
    Then I should get following values in body:
        | jsonPath              | expectedValue |
        | name                  | <name>        |
        | closed                | False         |
        | prefs.permissionLevel | private       |

    Examples:
      | name            |
      | test            |
      | $p€c!@l ch^r$   |