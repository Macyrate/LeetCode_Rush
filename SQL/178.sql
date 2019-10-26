select Score, 
(select count(distinct Score) 
 from Scores as b 
 where b.Score >= a.Score 
) as Rank
from Scores as a
order by Score desc;