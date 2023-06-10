Feature: Send email

    Scenario: 01 Login to page
        Given I have access to yopmail.com
        When I put my credentials
        Then I should be on my inbox

    Scenario: 02 Create an email
        Given I click on new email and set the data for the mail
        When I click on send button
        Then I should see a email was sent message

    Scenario: 03 Verify email sent
        Given I change to my inbox
        When I click on refresh button
        Then I should see the email subject