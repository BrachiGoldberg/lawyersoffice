# lawyersoffice

**

# > ישויות
1. לקוח
2. תיק
3. כספים - הכנסות

# > מיפויים

## מיפוי לקוח

 -  שליפת כל הלקוחות
 GET http://lowyer.co.il/costumers     

 - שליפת לקוח לפי מזהה           
 GET http://lowyer.co.il/costumers/1  
 
 - שליפת לקוח לפי שם
 GET http://lowyer.co.il/costumers/name  
 
-  הוספת לקוח
 POST http://lowyer.co.il/costumers  
 
-  עדכון לקוח
 PUT http://lowyer.co.il/costumers/1] 

## מיפוי תיק

 -   שליפת כל התיקים
 GET http://lowyer.co.il/courtcase

- שליפת תיק לפי מזהה
 GET http://lowyer.co.il/courtcase/1 
 
-  שליפת תיק לפי סוג תיק
 GET http://lowyer.co.il/courtcase/type 
 
 - הוספת תיק
 POST http://lowyer.co.il/courtcase 
  
-   עדכון תיק
 PUT http://lowyer.co.il/courtcase/1
  
  -  עדכון סטטוס תיק (פעיל/ לא פעיל)
PUT http://lowyer.co.il/courtcase/1/status
 

## מיפוי כספים - הכנסות

- שליפת כל ההכנסות
 GET http://lowyer.co.il/incomes
 
- שליפת הכנסה לפי מזהה
 GET http://lowyer.co.il/incomes/1
 
- שליפת הכנסה לפי תאריך
 GET http://lowyer.co.il/incomes/20.11.2023
 
- הוספת הכנסה
 POST http://lowyer.co.il/incomes

- עדכון הכנסה
  PUT http://lowyer.co.il/incomes/1

- מחיקת הכנסה
  DELETE http://lowyer.co.il/incomes/1

 

**
