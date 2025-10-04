// Visual for this example is available at: Assets/ProblemPattens/Recursion/JumpGame.svg

class JumpGame
{

    public bool JumpGameRecursion(int[] nums)
    {
        return CanReachEnd(0, nums);
    }

    public bool CanReachEnd(int position,int[] nums) {
        return true;
    }

    /*
    Stack: canJump(0)
    Stack: canJump(0) → canJump(1)  
    Stack: canJump(0) → canJump(1) → canJump(2)
    Stack: canJump(0) → canJump(1) → canJump(2) → canJump(3)
    Stack: canJump(0) → canJump(1) → canJump(2) → canJump(3) → canJump(4)

    canJump(4) returns TRUE
    canJump(3) returns TRUE  
    canJump(2) returns TRUE
    canJump(1) returns TRUE
    canJump(0) returns TRUE
    */
}
