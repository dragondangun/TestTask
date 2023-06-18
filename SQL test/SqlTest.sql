-- Мне кажется, что я здесь где-то ошибся, хоть и понимаю джойны и связь многое ко многим,
-- но всё равно не уверен. 

SELECT productName, categoryName FROM Products
    LEFT JOIN 
    (SELECT productId, categoryId FROM Products AS p
        LEFT JOIN ProductsCategories AS pc ON p.productId = pc.productId) AS r
        ON r.productId=p.productId
        LEFT JOIN Categories AS c ON r.categoryId=c.categoryId 
