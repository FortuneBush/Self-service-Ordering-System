# Self-Service Ordering System - "EatFull" Breakfast Shop

## Project Overview

The self-service ordering system at "EatFull" breakfast shop is introduced to enhance efficiency and reduce labor costs. This modern ordering solution allows customers to conveniently and independently place their orders using touch-screen devices embedded on the dining tables, providing a more streamlined dining experience.

## Background

- Business Hours: 6:00 AM to 10:00 AM
- Food Categories:
  1. Main Course: Porridge, Buns, Wonton, Pastry
  2. Dishes: Cold Dishes, Eggs
  3. Beverages: Soy Milk, Mineral Water, Milk
- Ordering Device: Touch-screen devices (standard tablet size)

## Requirements

1. Customers can independently place their orders using the self-service system.
2. Customers use pre-issued membership cards for payment by entering their membership number and password.
3. Customers are reminded to recharge their cards if the balance is insufficient.
4. Display the estimated waiting time for each food item.
5. Notify customers when their orders are ready for self-service pick-up.

## User Guide

1. **Self-Service Ordering**
   - Use the touch-screen device to select desired food items from the menu.
   - Enter the membership number and password to complete the payment.

2. **Membership Card Recharge**
   - During the payment process, the system will prompt members with insufficient balance to recharge.

3. **Waiting Time Display**
   - The system displays the estimated waiting time for each food item during the ordering process.

4. **Pick-Up Notification**
   - Once the food is prepared, the system will provide on-screen text/graphic prompts for customers to pick up their orders.

## Project Structure

- **SelfServiceOrderingSystemForm.vb:** Main form class
- **SelfServiceOrderingSystemForm.Designer.vb:** Form designer-generated code
- **FoodClass.vb:** Class definition for food items
- **MenuListClass.vb:** Class definition for the menu list
- **README.md:** Project documentation

## Food Class - FoodClass

```vb
Public Class FoodClass
    ' ...（Omitted, the definition of the FoodClass is in the FoodClass.vb file）
End Class
```

## Menu List Class - MenuListClass

```vb
Public Class MenuListClass
    ' ...（Omitted, the definition of the MenuListClass is in the MenuListClass.vb file）
End Class
```

## Important Notes

- Ensure the accuracy of the entered membership number and password.
- Maintain a stable network connection during the payment and recharge processes.

**"EatFull" Breakfast Shop's self-service ordering system makes your breakfast experience more convenient!**