
/* BONUSES
If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.

SCORE REWARDS
/*If the player scores greater or equal to 16, they'll win a new car.
If the player scores greater or equal to 10, they'll win a new laptop.
If the player scores exactly 7, they'll win a trip.
Otherwise, the player wins a kitten.
*/


Random dice = new Random(); //Since the Class is stateful we first create an object instance
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: First Die = {roll1} || Second Die = {roll2} || Third Die = {roll3} || Total = {total}");

//BONUS CONDITIONS
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{  
if ((roll1 == roll2) && (roll2 == roll3) && (roll3 == roll1)) 
{
    Console.WriteLine("You rolled triplets! +6 bonus to total");
    total += 6;
}
else {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
}

//SCORE REWARD CONDITIONS

if (total >= 16) 
{ 
    Console.WriteLine("YOU WON A CAR !!!");
}
    else if (total >= 10) 
    {
        Console.WriteLine("YOU WON A LAPTOP !!!");
    }

    else if (total == 7)
    {
        Console.WriteLine("YOU WON A TRIP TO TURKEY");
    }

    else 
    {
        Console.WriteLine("YOU WON A BOTTLE OF WINE");
    }

