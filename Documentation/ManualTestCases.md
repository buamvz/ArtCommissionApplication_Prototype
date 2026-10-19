# Manual Test Cases
Any test cases for GUI that are performed manually

- names up to change

# Test Case ID: MTC-01
Requirement ID: REQ-CLI-01
Test Name: Submit Commission Request Form

Preconditions:
- Client account exists.

Test Steps:
1. Log in as a client.
2. Navigate to the "Home" page.
3. Click the "Commission Request Form" button.
4. Fill the form with valid information.
5. Click the "Submit" button.

Expected Result:
- Commission Request form submission is successful.
- The form displays an accurate summary of the commission.

Actual Result:
- The submission is successful and displays a correct summary fo the request.

Status:
Passed


# Test Case ID: MTC-02
Requirement ID: REQ-SYS-06
Test Name: New Commission Requests are Status: Pending

Preconditions:
- Client account exists.
- Artist account exists.
- Commission request has been successfully submited.

Test Steps:
1. Log in as a artist.
2. Navigate to the "Comissions Queue" page.
3. View new commission requests.

Expected Result:
- Newly submitted commission requests have the status pending.

Actual Result:
- New commission requests have the default staus pending

Status:
Passed


# Test Case ID: MTC-03
Requirement ID: REQ-CLI-02
Test Name: Estimated  Price

Preconditions:
- Client account exists.

Test Steps:
1. Log in as a client.
2. Navigate to the "Home" page.
3. Click the "Commission Request Form" button.
4. Fill the form with valid information.
5. View the estimated price display.

Expected Result:
- Estimated price should update with each input changed in the form.
- The estimated price should accurately reflect the commission price.

Actual Result:
- The estimate price updates accurately to the commission price.

Status:
Passed


# Test Case ID: MTC-04
Requirement ID: REQ-CLI-03
Test Name: Commission request summary.

Preconditions:
- Client account exists.
- Artist account exists.

Test Steps:
1. Log in as a client.
2. Navigate to the "Home" page.
3. Click the "Commission Request Form" button.
4. Fill the form with valid information.
5. Submit request.
6. View the form summary.

Expected Result:
- The commission request summary accurately displays the commission request information and artist's username

Actual Result:
- The summary accurately displays the commission reqest information and artist name.

Status:
Passed


# Test Case ID: MTC-05
Requirement ID: REQ-CLI-04
Test Name: Clients can view their own commission requests.

Preconditions:
- Client account exists.
- Client has sumbitted at least one commission request

Test Steps:
1. Log in as a client.
2. Navigate to the "My Commission Requests" page.
3. Reload my commissions list.
4. View client's requested commissions list.

Expected Result:
- Client can view commission requests in the list
- Only commissions under the clients name are in the list.
- Commission request objects include all commission information including up to date status.

Actual Result:
- Client can see only their own commission requests in the my commissions list with accurate information and status.

Status:
Passed


# Test Case ID: MTC-06
Requirement ID: REQ-SYS-08	
Test Name: Commissions marked completed are removed from the public queue

Preconditions:
- Artist account exists.
- At least one commission request exists in the database.
- Client account exists

Test Steps:
1. Log in as the artist.
2. Navigate to the "Accepted Commissions" page.
3. Mark status of an in progress Commission to completed.
4. Log in as a client.
5. Navigate to the "Public queue" page.
6. View Commissions in the public queue.

Expected Result:
- Commission mared completed is no longer present in the public queue.

Actual Result:
- Once marked completed, clients can no longer see commissions in the public queue.

Status:
Passed


# Test Case ID: MTC-07
Requirement ID: REQ-SYS-09
Test Name: Public queue only displays public information.

Preconditions:
- Client account exists.
- At least one commission request exists and is marked accepted or in progress

Test Steps:
1. Log in as a client.
2. Navigate to the "Public Queue" page.
3. View the columns in of the public queue data grid/table.

Expected Result:
- Only columns Commission ID, client name, crop type, number of characters, background, and status exist.

Actual Result:
- Public view only has the required columns of commission request data.

Status:
Passed


# Test Case ID: MTC-08
Requirement ID: REQ-ART-01
Test Name: View Incoming Commission Requests

Preconditions:
- Artist account exists.
- At least one commission request exists in the database.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Commission Requests" page.
3. View the list of incoming commission requests.

Expected Result:
- All incoming commission requests are displayed.
- Each request shows the client's name.
- Each request shows the estimated price.

Actual Result:
- All requests displayed correctly with client name and estimated price.

Status:
Passed


# Test Case ID: MTC-09
Requirement ID: REQ-ART-02
Test Name: Pending commissions Status update options

Preconditions:
- Artist account exists.
- At least one commission request exists in the database with status pending.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Incoming Commissions" page.
3. Click the status combo box.

Expected Result:
- Pending commission can only status change to accepted or rejected.

Actual Result:
- All requests displayed correctly with client name and estimated price.

Status:
Passed


# Test Case ID: MTC-10
Requirement ID: REQ-SYS-11
Test Name: Client Recieves notification

Preconditions:
- Client account exists.
- Client has a pending commission request.
- Artist account exists.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Incoming Commmissions" page.
3. Change the clients commission from pending to accepted or rejected.
4. Log in as the client

Expected Result:
- Upon logging in as the client, a notification window 
  appears with the commission request id and its updated status.

Actual Result:
- The notification appears with the correct commission ID and updated status.

Status:
Passed


# Test Case ID: MTC-11
Requirement ID: REQ-ART-03
Test Name: Status: Accepted commissions status update

Preconditions:
- Artist account exists.
- At least one commission request exists in the database.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Accepted commissions" page.
3. Click the combo box of an accepted commission

Expected Result:
- Combo box options should include pending, rejected, accepted, in progress, and completed.

Actual Result:
- combo box options are accurate.

Status:
Passed


# Test Case ID: MTC-12
Requirement ID: REQ-ART-04
Test Name: Status: Artist can edit their profile information.

Preconditions:
- Artist account exists.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Artist Profile" page.
3. Edit username, email, and bio text fields
4. Click save changes button.

Expected Result:
- Artist profile information saved to database.
- Upon next opening "Artist Profile" page, the updated information is present.

Actual Result:
- Artist profile information saves to database and is updated each time viewing artist profile

Status:
Passed


# Test Case ID: MTC-13
Requirement ID: REQ-ART-05
Test Name: Status: Artist can edit their Terms of Service information.

Preconditions:
- Artist account exists.

Test Steps:
1. Log in as the artist.
2. Navigate to the "My Terms of Service" page.
3. Edit general rules, will draw, and won't draw text fields
4. Click save changes button.

Expected Result:
- Artist Terms of Service information saved to database.
- Upon next opening "My Terms of Service" page, the updated information is present.

Actual Result:
- Artist Terms of Service information saves to database and is updated each time viewing My Terms of Service

Status:
Passed


# Test Case ID: MTC-14
Requirement ID: REQ-ART-06
Test Name: Status: Artist profile information updates on the client dashboard.

Preconditions:
- Artist account exists.
- Artist has filled their profile information
- Client account exists

Test Steps:
1. Log in as the artist.
2. Navigate to the "Artist Profile" page.
3. Edit username, email, and bio text fields
4. Click save changes button.
5. Login as a client
6. Navigate to the "About [artist username]" page.
7. View artist about page

Expected Result:
- Username, email, and bio diplayed should be up to date with the edited artist information.

Actual Result:
- Artist profile information on the client dashboard matches the edited version from the artist side.

Status:
Passed


# Test Case ID: MTC-15
Requirement ID: REQ-ART-07
Test Name: Status: Artist Terms of Service information updates on the client dashboard.

Preconditions:
- Artist account exists.
- Artist has filled their profile information
- Client account exists

Test Steps:
1. Log in as the artist.
2. Navigate to the "My Terms of Service" page.
3. Edit general rules, will draw, and won't draw text fields
4. Click save changes button.
5. Login as a client
6. Navigate to the "Terms of service" page.
7. View terms of service about page

Expected Result:
- Username, email, and bio diplayed should be up to date with the edited artist information.

Actual Result:
- Artist profile information on the client dashboard matches the edited version from the artist side.

Status:
Passed


# Test Case ID: MTC-16
Requirement ID: REQ-SYS-13
Test Name: Status: Bio and TOS Character limit.

Preconditions:
- Artist account exists.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Artist Profile" page.
3. Attempt to write 2001 characters in the Bio text field.
5. Navigate to the "My Terms of service" page.
6. Attempt to write 2001 characters in the general text field.

Expected Result:
- Text fields will prevent the user from inputting more than 2000 characters of text.
- Text fields will allow 200 or less characters.

Actual Result:
- Can write up to but no more than 2000 characters, they stop being added to the text field.

Status:
Passed


# Test Case ID: MTC-17
Requirement ID: REQ-SYS-14
Test Name: Status: Client dashboard tabs

Preconditions:
- Client account exists

Test Steps:
1. Log in as the client.
2. View the avaiable tabs.

Expected Result:
- The client view consists of main tabs Artist Username and My profile. 
Under artist name contains tabs home, about artist name, terms of service, samples of work, and public queue.

Actual Result:
- All tabs are present and interactable.

Status:
Passed


# Test Case ID: MTC-18
Requirement ID: REQ-SYS-16
Test Name: Status: Commission form submit time

Preconditions:
- Client account exists.

Test Steps:
1. Log in as a client.
2. Navigate to the "Home" page.
3. Click the "Commission Request Form" button.
4. Fill the form with valid information.
5. Click the "Submit" button.

Expected Result:
- After clicking submit, the commission request summary is shown in no more than 3 seconds.

Actual Result:
- the commission request summary appears in under 3 seconds.

Status:
Passed


# Test Case ID: MTC-19
Requirement ID: REQ-SYS-17
Test Name: Database response time

Preconditions:
- Artist account exists.
- At least one commission request exists in the database with status pending.

Test Steps:
1. Log in as the artist.
2. Navigate to the "Incoming Commissions" page.
3. Click the status combo box and change the pending status to accepted.
4. Navigate to the "Accepted Commissions" page.

Expected Result:
- When viewing the accepted commissions page, the commission whose status just changed appears within at least 1 second

Actual Result:
- The commission updates in accepted commissions as soon as it is opened or refreshed

Status:
Passed



# Test Case ID: MTC-20
Requirement ID: REQ-SYS-18
Test Name: Public Queue updates imediately

Preconditions:
- Artist account exists.
- At least one commission request exists in the database.
- Client account exists

Test Steps:
1. Log in as the artist.
2. Navigate to the "Accepted Commissions" page.
3. Mark status of an in progress Commission to completed.
4. Log in as a client.
5. Navigate to the "Public queue" page.
6. View Commissions in the public queue.

Expected Result:
- Public queue is up to date with the artist's most recent inputs.

Actual Result:
- public queue is up to date with the artist's most recent inputs.

Status:
Passed



# Test Case ID: MTC-21
Requirement ID: REQ-SYS-19
Test Name: Status: Clear user interface

Preconditions:
- Client account exists
- Artist account exists
- Admin account exists

Test Steps:
1. Log in as the client.
2. User to navigate interface to request a commissions.
1. Login as the artist
1. User to navigate to edit thier profile information.
1. User to navigate to edit thier terms of service information.
1. User to navigate to move a commission from pending to completed.
1. Login as the admin.
1. User to navigate to report the estimated tax of current accepted commissions.

Expected Result:
- The user can navigate with no errors to complete and submit a commission form.

Actual Result:
- one outside tester able to navigate with no errors, however we'd need more tests to be sure.

Status:
Unverified
