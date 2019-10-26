select distinct b.Num as ConsecutiveNums
from Logs as a inner join Logs as b on a.Id = b.Id-1 and a.Num = b.Num
inner join Logs as c on b.Id = c.Id-1 and b.Num = c.Num;

/* 大佬做法 */
select distinct Num as ConsecutiveNums
from (
select Num, if((@pre=(@pre:=Num)), @a:=@a+1, @a:=1) as n    /* if相当于三目运算，这里运用了'='先算左边的左结合性' */
from Logs, (select @a:=0, @pre:='a') t
) as temp
where n >= 3
order by Num desc
