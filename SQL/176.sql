select(
    select distinct Salary
    from Employee
    order by Salary desc
    limit 1 offset 1        /* 分页截取第二行 */
) as SecondHighestSalary;