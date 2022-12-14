**Gift Delivery App API**
-----------

This API is modeled after an app for which I developed. It's a cross between 1-800-Flowers and DoorDash in that users may order gifts to loved ones in a fast and efficient way.

I added a column for a personal message to add a personal touch for each order.

This API allows the developer to examine orders made by the app user and make changes to them.

**Endpoints:**
----------
**GET**   api/gift (shows a list of all orders placed)

**DELETE**  api/gift/{id} (allows developer to delete an order)

**PUT**   api/gift/{id} (allows developer to change an order)


**Challenges:**
----------
The main issue that I faced was an error which required me to downgrade the packages until I found a combination that worked.
I also faced challenges returning the response model so I decided to put the string into the error itself.


**Tables:**
------------

<img width="440" alt="Screenshot 2022-10-23 at 10 51 20 PM" src="https://user-images.githubusercontent.com/77247203/205768558-33a56f1a-f333-457b-b0eb-2462be0e6a8d.png">
