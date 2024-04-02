using callcenter;

CallCenter callcenter = new CallCenter();

Call d = new Call("pedro", 2);
Call e = new Call("Márcio", 4);
Call f = new Call("Everton", 6);
Call g = new Call("Torquato", 2);
callcenter.callQueue.Enqueue(d);
callcenter.callQueue.Enqueue(e);
callcenter.callQueue.Enqueue(f);
callcenter.callQueue.Enqueue(g);
callcenter.processQueue();


