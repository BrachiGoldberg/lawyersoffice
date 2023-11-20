# lawyersoffice




**

# > ישויות
1. לקוח
2. תיק
3. כספים - הכנסות

# > מיפויים

## מיפוי לקוח

 -  שליפת כל הלקוחות
 GET http://lawyer.co.il/costumers     

 - שליפת לקוח לפי מזהה           
 GET http://lawyer.co.il/costumers/1  
 
 - שליפת לקוח לפי שם
 GET http://lawyer.co.il/costumers/name  
 
-  הוספת לקוח
 POST http://lawyer.co.il/costumers  
 
-  עדכון לקוח
 PUT http://lawyer.co.il/costumers/1

## מיפוי תיק

 -   שליפת כל התיקים
 GET http://lawyer.co.il/courtcase

- שליפת תיק לפי מזהה
 GET http://lawyer.co.il/courtcase/1 
 
-  שליפת תיק לפי סוג תיק
 GET http://lawyer.co.il/courtcase/type 
 
 - הוספת תיק
 POST http://lawyer.co.il/courtcase 
  
-   עדכון תיק
 PUT http://lawyer.co.il/courtcase/1
  
  -  עדכון סטטוס תיק (פעיל/ לא פעיל)
PUT http://lawyer.co.il/courtcase/1/status
 

## מיפוי כספים - הכנסות

- שליפת כל ההכנסות
 GET http://lawyer.co.il/incomes
 
- שליפת הכנסה לפי מזהה
 GET http://lawyer.co.il/incomes/1
 
- שליפת הכנסה לפי תאריך
 GET http://lawyer.co.il/incomes/20.11.2023
 
- הוספת הכנסה
 POST http://lawyer.co.il/incomes

- עדכון הכנסה
  PUT http://lawyer.co.il/incomes/1

- מחיקת הכנסה
  DELETE http://lawyer.co.il/incomes/1

 

**
