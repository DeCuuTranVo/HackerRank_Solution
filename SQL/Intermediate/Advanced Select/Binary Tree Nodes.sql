-- -- Find Root Node
-- SELECT N 
-- FROM BST
-- WHERE P IS NULL;

-- -- Find Leaf Node
-- SELECT N 
-- FROM BST
-- WHERE N NOT IN(SELECT DISTINCT P
-- FROM BST
-- WHERE P IS NOT NULL);

SELECT N,
CASE
    WHEN (P IS NULL) THEN "Root"
    WHEN (N NOT IN(SELECT DISTINCT P FROM BST WHERE P IS NOT NULL)) THEN "Leaf"
    ELSE "Inner"
END
FROM BST
ORDER BY N;
