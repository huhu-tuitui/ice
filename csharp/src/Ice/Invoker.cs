//
// Copyright (c) ZeroC, Inc. All rights reserved.
//
using System.Threading.Tasks;

namespace ZeroC.Ice
{
    /// <summary>An invoker is a delegate used to send an outgoing request.</summary>
    /// <param name="target">The proxy for the invocation.</param>
    /// <param name="request">The outgoing request being sent.</param>
    /// <returns>The incoming response frame.</returns>
    public delegate ValueTask<IncomingResponseFrame> Invoker(IObjectPrx target, OutgoingRequestFrame request);

    /// <summary>An invocation interceptor can be registered with a Communicator to intercept proxy invocations.
    /// </summary>
    /// <param name="target">The proxy for the invocation.</param>
    /// <param name="request">The outgoing request being sent.</param>
    /// <param name="next">The next invoker in the invocation chain.</param>
    /// <returns>The incoming response frame.</returns>
    public delegate ValueTask<IncomingResponseFrame> InvocationInterceptor(
        IObjectPrx target,
        OutgoingRequestFrame request,
        Invoker next);
}