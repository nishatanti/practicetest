Feature: searchwindow
	
 Verify search window functionality

 
 Scenario: Search window functionality
 
    Given User is On HomePage
    And  Enter all the details of ISW 

    | Source | Destination | DeptDate   | ReturnDate | Adult | Class    |
    | LAX    | NYC         | 09/20/2020 | 09/25/2020 | 2     | Business |
    And  Click on search button
    And  User is navigated to listing page