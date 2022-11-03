Feature: API
	Simple calculator for adding two numbers

Scenario: Verify API returns status code 200 OK
	Given I perform GET operation for "/api/users?page={pageno}"
	And I perform operation for post "2"
	Then I should see the status code OK

Scenario: Verify API content type is application/json
	Given I perform GET operation for "/api/users?page={pageno}"
	And I perform operation for post "2"
	Then I should see the content type as "application/json"


@mytag
Scenario: Verify author of the posts 1 
	Given I perform GET operation for "/api/users?page={pageno}"
	And I perform operation for post "2"
	Then I should see the "page" name as "2"