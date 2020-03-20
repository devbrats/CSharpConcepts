# EventsAndDelegates
This project contains the basic concept of events and delegates and how to use them

 #### 1.Define Delegate
 public **delegate** void Delegate1();<br/>
 public **delegate** void Delegate2(int x);
 
 #### 2.Declare and Instantiation
 Delegate1 delegate1 = MethodsRepository.Display;
 
 #### 3.Invoke
 delegate1.Invoke();
 
 #### 4.Add
 delegate1 += MethodsRepository.TestDisplay;
 delegate1.Invoke();
 
 #### 5.Remove
 delegate1 -= MethodsRepository.Display;
 delegate1.Invoke();
 
 #### 6.Calling method with parameter using delegate
 Delegate2 delegate2 = MethodsRepository.DisplayValues;<br/>
 delegate2.Invoke(8);
 
 #### 7.Reinstantiate and Invoke
 delegate1 = MethodsRepository.ReTestDisplay;<br/>
 delegate1.Invoke();
 
 #### 8.Return a Delegate
 var del = MethodsRepository.GetDisplayMethod();
 del.Invoke();
 
 #### 9.Pass delegate as parameter
 MethodsRepository.InvokeDelegate(delegate1);
