CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
  SET N = N-1;      /* 运算符没法用在后面的offset里，故这里提前处理 */
  RETURN (
      # Write your MySQL query statement below.
      select(
          select distinct Salary
          from Employee
          order by Salary desc
          limit 1 offset N        /* 分页截取第二行 */
      ) as getNthHighestSalary
  );
END