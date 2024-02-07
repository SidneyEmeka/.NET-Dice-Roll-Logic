
/* DICE ROLL
If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.*/

Random dice = new Random(); //Since the Class is stateful we first create an object instance
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: First Die = {roll1} || Second Die = {roll2} || Third Die = {roll3} || Total = {total}");

//First Condition
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

//Second Condition
if ((roll1 == roll2) && (roll2 == roll3) && (roll3 == roll1)) 
{
    Console.WriteLine("You rolled triplets! +6 bonus to total");
    total += 6;
}


//Third Condition
if (total >= 15)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry, you lose.");
}


