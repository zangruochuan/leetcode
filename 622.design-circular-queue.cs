/*
 * @lc app=leetcode.cn id=622 lang=csharp
 *
 * [622] Design Circular Queue
 *
 * https://leetcode-cn.com/problems/design-circular-queue/description/
 *
 * algorithms
 * Medium (36.40%)
 * Total Accepted:    3.5K
 * Total Submissions: 9.5K
 * Testcase Example:  '["MyCircularQueue","enQueue","enQueue","enQueue","enQueue","Rear","isFull","deQueue","enQueue","Rear"]\n[[3],[1],[2],[3],[4],[],[],[],[4],[]]'
 *
 * 设计你的循环队列实现。 循环队列是一种线性数据结构，其操作表现基于
 * FIFO（先进先出）原则并且队尾被连接在队首之后以形成一个循环。它也被称为“环形缓冲器”。
 * 
 * 循环队列的一个好处是我们可以利用这个队列之前用过的空间。在一个普通队列里，一旦一个队列满了，我们就不能插入下一个元素，即使在队列前面仍有空间。但是使用循环队列，我们能使用这些空间去存储新的值。
 * 你的实现应该支持如下操作：
 * 
 * 
 * MyCircularQueue(k): 构造器，设置队列长度为 k 。
 * Front: 从队首获取元素。如果队列为空，返回 -1 。
 * Rear: 获取队尾元素。如果队列为空，返回 -1 。
 * enQueue(value): 向循环队列插入一个元素。如果成功插入则返回真。
 * deQueue(): 从循环队列中删除一个元素。如果成功删除则返回真。
 * isEmpty(): 检查循环队列是否为空。
 * isFull(): 检查循环队列是否已满。
 * 
 * 
 * 示例：
 * 
 * 
 * MyCircularQueue circularQueue = new MycircularQueue(3); // 设置长度为3
 * 
 * circularQueue.enQueue(1);  // 返回true
 * 
 * circularQueue.enQueue(2);  // 返回true
 * 
 * circularQueue.enQueue(3);  // 返回true
 * 
 * circularQueue.enQueue(4);  // 返回false,队列已满
 * 
 * circularQueue.Rear();  // 返回3
 * 
 * circularQueue.isFull();  // 返回true
 * 
 * circularQueue.deQueue();  // 返回true
 * 
 * circularQueue.enQueue(4);  // 返回true
 * 
 * circularQueue.Rear();  // 返回4
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 所有的值都在 1 至 1000 的范围内；
 * 操作数将在 1 至 1000 的范围内；
 * 请不要使用内置的队列库。
 * 
 * 
 */


public class MyCircularQueue {

    private int sizeMax = 1000;

    private int size;

    private int head;

    private int tail;

    private int length;

    private int[] data;
    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        if (k>sizeMax)
        {
            size = 1000;
        } else
        {
            size = k;  
        }
        head = 0;
        tail = -1;
        length = 0;
        data = new int[k];
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        if (IsFull())
        {
            return false;
        }
        tail++;
        if (tail>=size)
        {
            tail = 0;
        }
        data[tail] = value;  
        length++;
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if (IsEmpty())
        {
            return false;
        }
        data[head] = -1;
        head++;
        if (head>=size)
        {
            head = 0;
        }
        length--;
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() {
        if (IsEmpty())
        {
            return -1;
        } else
        {
            return data[head];
        }        
    }
    
    /** Get the last item from the queue. */
    public int Rear() {
        if (IsEmpty())
        {
            return -1;
        } else
        {
            return data[tail];
        }
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return length <= 0?true:false;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return length >= size?true:false;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
