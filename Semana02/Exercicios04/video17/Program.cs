//crud

//create
List<int> nums = [1, 2, 3, 4, 5];

//read
foreach(var num in nums)
{
    Console.WriteLine(num);
}

//update
nums.Add(0); //o método mais rátpido
foreach(var num in nums)
{
    Console.WriteLine(num);
}

nums.Insert(0, 0); //escolhe onde põe
foreach(var num in nums)
{
    Console.WriteLine(num);
}

//delete
//var newNum = nums.Where((i) => i == 2); filtro
nums.Remove(1);
nums.RemoveAt(0);
foreach(var num in nums)
{
    Console.WriteLine(num);
}
