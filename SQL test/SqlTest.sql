SELECT productName, categoryName FROM products AS p
    LEFT JOIN 
    (SELECT p.productId, categoryId FROM products AS p
        LEFT JOIN productsCategories AS pc ON p.productId = pc.productId) AS r
        ON r.productId=p.productId
        LEFT JOIN Categories AS c ON r.categoryId=c.categoryId 
