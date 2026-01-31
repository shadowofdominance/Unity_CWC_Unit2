# Create With Code Unit - 2 | Unity Version 6000.3.4f1

## *So what things did I learn from this unit??*
- Learned how to *spawn* or *shoot* projectiles after a key is pressed.
- Learned how *colliders* work in Unity.
- Learned how to spawn *objects* randomly on any given location range.

## Major Programming Concepts Learned
- Learnt how to use the `Instantiate` function. Implemented in [SpawnManager](Assets/Scripts/SpawnManager.cs#L-23)
- Learnt how to keep the *player* in bounds using `if` statements.
- Learnt how to use `InvokeRepeating`.
- `InvokeRepeating` can be used to invoke a function repeatedly with a given time interval. Implemeted in [SpawnManager](Assets/Scripts/SpawnManager.cs#L-12)
- Also learned about how we can use `Random.Range`. But we have to be careful while using this because we cannot use it in an initialization of a *global variable*, you have to use locally inside a *function*. For some reason this happens only in a class derived by `MonoBehaviour` class.

## Completed the challenge and Solved all the Bugs

#### Dogs are spawning at the top of the screen
- Solution: Dogs were spawning on the top because the *dog game object* was added in the place of ball.

#### The player is spawning green balls instead of dogs
- Solution: Click on `Player` and change the game object to dog in the inspector.

#### The balls are destroyed if anywhere near the dog
- Solution: The *collider* for the dog is too big, we have to adjust it properly!

#### Nothing is being destroyed off screen
- Soltion: In [DestroyOutOfBoundsX.cs](Assets/Challenge%202/Scripts/DestroyOutOfBoundsX.cs) we have change the variables to `leftLimit = -45` & `bottomLimit = -5` and also change the if conditions to `if (transform.position.x < leftLimit)` & `else if (transform.position.y < bottomLimit)`

#### Only one type of ball is being spawned
- Solution: We have to change a few things in the [SpawnManagerX.cs](Assets/Challenge%202/Scripts/SpawnManagerX.cs)
- Initialise a new variable inside `SpawnRandomBall`, `int randomIndex = Random.Range(0, ballPrefabs.Length);` and add that in the `Instantiate`

#### Bonus: The spawn interval is always the same
- Solution: To change the spawn interval in [SpawnManagerX.cs](Assets/Challenge%202/Scripts/SpawnManagerX.cs) we have just add anew line before we call `InvokeRepeating`. We should add this line `float spawnInterval = Random.Range(1.0f, 2.5f);`.

#### Bonus: The player can “spam” the spacebar key
- Solution: We should add a cooldown as given in the [PlayerControllerX.cs](Assets/Challenge%202/Scripts/PlayerControllerX.cs)

> Thank you for reading this far!
