# Signum - .NET SDK

## .NET SDK

This SDK is a work in progress and is by no means feature complete.  Current state is more directed to read-only functions.

- .NET 6 
- 
- 

## SDK Tests

A Test project has been created to facilitate in the progress of the SDK.  This is a work in progress as well.


`signum-test.runsettings` file is used to help facilitate test funcitons.  
If you are getting failing test, check here first.  Main setting of concern
is going to be the `webAppUrl` value.

```sql
	<!-- Parameters used by tests at run time _ Connect to Signum TestNet Node -->
	<TestRunParameters>
		<Parameter name="webAppUrl" value="http://test-srs-node:6876/" />
		<Parameter name="apiKey" value="e673529588638d2129af1e0528a1642cf2e0c180" />
		<Parameter name="accountID" value="5812913123670292755" />
		<Parameter name="accountRS" value="TS-7YAM-Q2DB-UXXS-7XWC3" />
		<Parameter name="poolAccountID" value="13821577863870965285" />
		<Parameter name="poolAccountRS" value="TS-WTK7-UTFQ-9DUV-DV2NZ" />
		
		<Parameter name="badaccountID" value="5812913123670292753829345" />
	</TestRunParameters>
```

## Worker App Example
This example helps illustrate how to add the SignumAPI as part of the DI container for a .NET application.  A `Worker` is used as part of the process.

The `appsettings.json` file is used to configure the Signum Node Http Address and ApiKey if you want to test functions that use this.


```json
"SignumNodeUri": "http://test-srs-node:6876/",
  "SignumApiKey": "apikeyinnodeconfigfile",
```

