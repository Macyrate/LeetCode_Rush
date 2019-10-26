SELECT MIN(a.x-b.x) AS shortest
FROM point a,point b
WHERE a.x > b.x;

/* 进阶 */
select a.id pointa, b.id pointb, min(a.x-b.x) shortest
from point a, point b 
where a.x > b.x;