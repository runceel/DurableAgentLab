## Repro steps

1. Launch FunctionApp17 project
2. Open FunctionApp17/test.http
3. Send a request

Complete output:
```
'local.settings.json' found in root directory (D:\source\FunctionApp17\FunctionApp17\bin\Debug\net10.0).
Resolving worker runtime to 'dotnet-isolated'.


Azure Functions Core Tools
Core Tools Version:       4.5.0+e74aae22c9630777c9f58354f290a6e214218546 (64-bit)
Function Runtime Version: 4.1044.400.25520

[2025-11-18T22:57:52.245Z] Found D:\source\FunctionApp17\FunctionApp17\FunctionApp17.csproj. Using for user secrets file configuration.
[2025-11-18T22:57:55.449Z] Durable Functions Distributed Tracing V2 is GA now! Learn how to enable the feature by visiting aka.ms/durable-distributed-tracing. To disable this message, you can configure distributedTracingEnabled to "true" and version to "V2" or "None". Setting it to "None" would in effect disable the feature.
[2025-11-18T22:57:56.269Z] MCP server endpoint: http://localhost:7268/runtime/webhooks/mcp
[2025-11-18T22:57:56.270Z] MCP server legacy SSE endpoint: http://localhost:7268/runtime/webhooks/mcp/sse
[2025-11-18T22:58:00.786Z] Azure Functions .NET Worker (PID: 33456) initialized in debug mode. Waiting for debugger to attach...
[2025-11-18T22:58:00.928Z] Worker process started and initialized.

Functions:

        Function1_HttpStart: [GET,POST] http://localhost:7268/api/Function1_HttpStart

        http-echo: [POST] http://localhost:7268/api/agents/echo/run

        dafx-echo: entityTrigger

        Function1: orchestrationTrigger

For detailed output, run func with --verbose flag.
[2025-11-18T22:58:05.935Z] Host lock lease acquired by instance ID '000000000000000000000000C4B29B5C'.
[2025-11-18T22:58:13.803Z] Executing 'Functions.http-echo' (Reason='This function was programmatically called via the host APIs.', Id=cae66f01-a17d-4c55-baef-2489506e3f2a)
[2025-11-18T22:58:14.451Z] Signalling agent with session ID '@dafx-echo@cae66f01-a17d-4c55-baef-2489506e3f2a'
[2025-11-18T22:58:14.751Z] Polling agent with session ID '@dafx-echo@cae66f01-a17d-4c55-baef-2489506e3f2a' for response with correlation ID '7a3af7a19bda443a95c6e99cb0024457'
[2025-11-18T22:58:14.936Z] Executing 'Functions.dafx-echo' (Reason='(null)', Id=60947d1c-b1f6-45a5-bf22-1976006f4392)
[2025-11-18T22:58:15.030Z] Function 'dafx-echo', Invocation id '60947d1c-b1f6-45a5-bf22-1976006f4392': An exception was thrown by the invocation.
[2025-11-18T22:58:15.032Z] Result: Function 'dafx-echo', Invocation id '60947d1c-b1f6-45a5-bf22-1976006f4392': An exception was thrown by the invocation.
Type:
Exception: Microsoft.Azure.Functions.Worker.FunctionInputConverterException: Error converting 1 input parameters for Function 'dafx-echo': Cannot convert input parameter 'dispatcher' to type 'Microsoft.Azure.Functions.Worker.TaskEntityDispatcher' from type 'System.String'. Error:System.Text.Json.JsonException: 'C' is an invalid start of a value. Path: $ | LineNumber: 0 | BytePositionInLine: 0.
[2025-11-18T22:58:15.032Z]  ---> System.Text.Json.JsonReaderException: 'C' is an invalid start of a value. LineNumber: 0 | BytePositionInLine: 0.
[2025-11-18T22:58:15.033Z]    at System.Text.Json.ThrowHelper.ThrowJsonReaderException(Utf8JsonReader& json, ExceptionResource resource, Byte nextByte, ReadOnlySpan`1 bytes)
[2025-11-18T22:58:15.034Z]    at System.Text.Json.Utf8JsonReader.ConsumeValue(Byte marker)
[2025-11-18T22:58:15.034Z]    at System.Text.Json.Utf8JsonReader.ReadFirstToken(Byte first)
[2025-11-18T22:58:15.035Z]    at System.Text.Json.Utf8JsonReader.ReadSingleSegment()
[2025-11-18T22:58:15.036Z]    at System.Text.Json.Utf8JsonReader.Read()
[2025-11-18T22:58:15.036Z]    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
[2025-11-18T22:58:15.037Z]    --- End of inner exception stack trace ---
[2025-11-18T22:58:15.037Z]    at System.Text.Json.ThrowHelper.ReThrowWithPath(ReadStack& state, JsonReaderException ex)
[2025-11-18T22:58:15.038Z]    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
[2025-11-18T22:58:15.039Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.ContinueDeserialize[TReadBufferState,TStream](TReadBufferState& bufferState, JsonReaderState& jsonReaderState, ReadStack& readStack, T& value)
[2025-11-18T22:58:15.039Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.DeserializeAsync[TReadBufferState,TStream](TStream utf8Json, TReadBufferState bufferState, CancellationToken cancellationToken)
[2025-11-18T22:58:15.039Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.DeserializeAsObjectAsync(Stream utf8Json, CancellationToken cancellationToken)
[2025-11-18T22:58:15.040Z]    at Microsoft.Azure.Functions.Worker.Converters.JsonPocoConverter.GetConversionResultFromDeserialization(Byte[] bytes, Type type) in /_/src/DotNetWorker.Core/Converters/JsonPocoConverter.cs:line 66
[2025-11-18T22:58:15.040Z]    at Microsoft.Azure.Functions.Worker.Context.Features.DefaultFunctionInputBindingFeature.BindFunctionInputAsync(FunctionContext context) in /_/src/DotNetWorker.Core/Context/Features/DefaultFunctionInputBindingFeature.cs:line 97
[2025-11-18T22:58:15.041Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:15.041Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:15.041Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:15.042Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 38
[2025-11-18T22:58:15.042Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:15.042Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76
Stack:    at Microsoft.Azure.Functions.Worker.Context.Features.DefaultFunctionInputBindingFeature.BindFunctionInputAsync(FunctionContext context) in /_/src/DotNetWorker.Core/Context/Features/DefaultFunctionInputBindingFeature.cs:line 97
[2025-11-18T22:58:15.043Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:15.043Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:15.043Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:15.044Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 38
[2025-11-18T22:58:15.044Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:15.044Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76.
[2025-11-18T22:58:15.118Z] Executed 'Functions.dafx-echo' (Failed, Id=60947d1c-b1f6-45a5-bf22-1976006f4392, Duration=184ms)
[2025-11-18T22:58:15.123Z] System.Private.CoreLib: Exception while executing function: Functions.dafx-echo. System.Private.CoreLib: Result: Failure
Type: Microsoft.Azure.Functions.Worker.FunctionInputConverterException
Exception: Error converting 1 input parameters for Function 'dafx-echo': Cannot convert input parameter 'dispatcher' to type 'Microsoft.Azure.Functions.Worker.TaskEntityDispatcher' from type 'System.String'. Error:System.Text.Json.JsonException: 'C' is an invalid start of a value. Path: $ | LineNumber: 0 | BytePositionInLine: 0.
[2025-11-18T22:58:15.124Z]  ---> System.Text.Json.JsonReaderException: 'C' is an invalid start of a value. LineNumber: 0 | BytePositionInLine: 0.
[2025-11-18T22:58:15.125Z]    at System.Text.Json.ThrowHelper.ThrowJsonReaderException(Utf8JsonReader& json, ExceptionResource resource, Byte nextByte, ReadOnlySpan`1 bytes)
[2025-11-18T22:58:15.125Z]    at System.Text.Json.Utf8JsonReader.ConsumeValue(Byte marker)
[2025-11-18T22:58:15.126Z]    at System.Text.Json.Utf8JsonReader.ReadFirstToken(Byte first)
[2025-11-18T22:58:15.127Z]    at System.Text.Json.Utf8JsonReader.ReadSingleSegment()
[2025-11-18T22:58:15.128Z]    at System.Text.Json.Utf8JsonReader.Read()
[2025-11-18T22:58:15.128Z]    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
[2025-11-18T22:58:15.129Z]    --- End of inner exception stack trace ---
[2025-11-18T22:58:15.130Z]    at System.Text.Json.ThrowHelper.ReThrowWithPath(ReadStack& state, JsonReaderException ex)
[2025-11-18T22:58:15.130Z]    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
[2025-11-18T22:58:15.131Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.ContinueDeserialize[TReadBufferState,TStream](TReadBufferState& bufferState, JsonReaderState& jsonReaderState, ReadStack& readStack, T& value)
[2025-11-18T22:58:15.132Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.DeserializeAsync[TReadBufferState,TStream](TStream utf8Json, TReadBufferState bufferState, CancellationToken cancellationToken)
[2025-11-18T22:58:15.132Z]    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.DeserializeAsObjectAsync(Stream utf8Json, CancellationToken cancellationToken)
[2025-11-18T22:58:15.133Z]    at Microsoft.Azure.Functions.Worker.Converters.JsonPocoConverter.GetConversionResultFromDeserialization(Byte[] bytes, Type type) in /_/src/DotNetWorker.Core/Converters/JsonPocoConverter.cs:line 66
Stack:    at Microsoft.Azure.Functions.Worker.Context.Features.DefaultFunctionInputBindingFeature.BindFunctionInputAsync(FunctionContext context) in /_/src/DotNetWorker.Core/Context/Features/DefaultFunctionInputBindingFeature.cs:line 97
[2025-11-18T22:58:15.134Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:15.134Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:15.137Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:15.137Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 38
[2025-11-18T22:58:15.138Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:15.139Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76
[2025-11-18T22:58:15.140Z]    at Microsoft.Azure.Functions.Worker.Handlers.InvocationHandler.InvokeAsync(InvocationRequest request) in /_/src/DotNetWorker.Grpc/Handlers/InvocationHandler.cs:line 89.
[2025-11-18T22:58:15.183Z] @dafx-echo@cae66f01-a17d-4c55-baef-2489506e3f2a: Function 'dafx-echo (Entity)' failed with an error. Reason: Microsoft.Azure.WebJobs.Host.FunctionInvocationException
   at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.ExecuteWithLoggingAsync(IFunctionInstanceEx instance, FunctionStartedMessage message, FunctionInstanceLogEntry instanceLogEntry, ParameterHelper parameterHelper, ILogger logger, CancellationToken cancellationToken) in /_/src/Microsoft.Azure.WebJobs.Host/Executors/FunctionExecutor.cs:line 357
[2025-11-18T22:58:15.189Z]    at Microsoft.Azure.WebJobs.Host.Executors.FunctionExecutor.TryExecuteAsync(IFunctionInstance functionInstance, CancellationToken cancellationToken) in /_/src/Microsoft.Azure.WebJobs.Host/Executors/FunctionExecutor.cs:line 113. IsReplay: False. State: Failed. RuntimeStatus: Failed. HubName: TestHubName. AppName: . SlotName: . ExtensionVersion: 3.8.0. SequenceNumber: 4. TaskEventId: -1
[2025-11-18T22:58:31.532Z] Function 'http-echo', Invocation id 'cae66f01-a17d-4c55-baef-2489506e3f2a': An exception was thrown by the invocation.
[2025-11-18T22:58:31.537Z] Result: Function 'http-echo', Invocation id 'cae66f01-a17d-4c55-baef-2489506e3f2a': An exception was thrown by the invocation.
Type:
Exception: System.Threading.Tasks.TaskCanceledException: A task was canceled.
[2025-11-18T22:58:31.537Z]    at Microsoft.Agents.AI.DurableTask.AgentRunHandle.ReadAgentResponseAsync(CancellationToken cancellationToken)
[2025-11-18T22:58:31.538Z]    at Microsoft.Agents.AI.DurableTask.DurableAIAgentProxy.RunAsync(IEnumerable`1 messages, AgentThread thread, AgentRunOptions options, CancellationToken cancellationToken)
[2025-11-18T22:58:31.539Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctions.RunAgentHttpAsync(HttpRequestData req, DurableTaskClient client, FunctionContext context)
[2025-11-18T22:58:31.540Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:31.541Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:31.542Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:31.543Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 54
[2025-11-18T22:58:31.543Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:31.544Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76
Stack:    at Microsoft.Agents.AI.DurableTask.AgentRunHandle.ReadAgentResponseAsync(CancellationToken cancellationToken)
[2025-11-18T22:58:31.545Z]    at Microsoft.Agents.AI.DurableTask.DurableAIAgentProxy.RunAsync(IEnumerable`1 messages, AgentThread thread, AgentRunOptions options, CancellationToken cancellationToken)
[2025-11-18T22:58:31.546Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctions.RunAgentHttpAsync(HttpRequestData req, DurableTaskClient client, FunctionContext context)
[2025-11-18T22:58:31.546Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:31.547Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:31.547Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:31.548Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 54
[2025-11-18T22:58:31.549Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:31.550Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76.
[2025-11-18T22:58:31.563Z] Executed 'Functions.http-echo' (Failed, Id=cae66f01-a17d-4c55-baef-2489506e3f2a, Duration=17819ms)
[2025-11-18T22:58:31.564Z] System.Private.CoreLib: Exception while executing function: Functions.http-echo. System.Private.CoreLib: Result: Failure
Type: System.Threading.Tasks.TaskCanceledException
Exception: A task was canceled.
Stack:    at Microsoft.Agents.AI.DurableTask.AgentRunHandle.ReadAgentResponseAsync(CancellationToken cancellationToken)
[2025-11-18T22:58:31.564Z]    at Microsoft.Agents.AI.DurableTask.DurableAIAgentProxy.RunAsync(IEnumerable`1 messages, AgentThread thread, AgentRunOptions options, CancellationToken cancellationToken)
[2025-11-18T22:58:31.565Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctions.RunAgentHttpAsync(HttpRequestData req, DurableTaskClient client, FunctionContext context)
[2025-11-18T22:58:31.566Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutor.ExecuteAsync(FunctionContext context)
[2025-11-18T22:58:31.567Z]    at Microsoft.Azure.Functions.Worker.OutputBindings.OutputBindingsMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/DotNetWorker.Core/OutputBindings/OutputBindingsMiddleware.cs:line 13
[2025-11-18T22:58:31.567Z]    at Microsoft.Agents.AI.Hosting.AzureFunctions.BuiltInFunctionExecutionMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next)
[2025-11-18T22:58:31.568Z]    at Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore.FunctionsHttpProxyingMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/extensions/Worker.Extensions.Http.AspNetCore/src/FunctionsMiddleware/FunctionsHttpProxyingMiddleware.cs:line 54
[2025-11-18T22:58:31.569Z]    at Microsoft.Azure.Functions.Worker.Extensions.Mcp.FunctionsMcpContextMiddleware.Invoke(FunctionContext context, FunctionExecutionDelegate next) in /_/src/Microsoft.Azure.Functions.Worker.Extensions.Mcp/FunctionsMiddleware/FunctionsMcpContextMiddleware.cs:line 24
[2025-11-18T22:58:31.569Z]    at Microsoft.Azure.Functions.Worker.FunctionsApplication.InvokeFunctionAsync(FunctionContext context) in /_/src/DotNetWorker.Core/FunctionsApplication.cs:line 76
[2025-11-18T22:58:31.569Z]    at Microsoft.Azure.Functions.Worker.Handlers.InvocationHandler.InvokeAsync(InvocationRequest request) in /_/src/DotNetWorker.Grpc/Handlers/InvocationHandler.cs:line 89.
```

