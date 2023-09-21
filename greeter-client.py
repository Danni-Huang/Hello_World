import zeep

client = zeep.Client(wsdl='http://localhost:8089/Greetings/?wsdl')

req = {
	'Recipient': "Homer"
}

greetingResp = client.service.Greet(req)
print(f'The greeting result from our service is: {greetingResp.Greeting} (for time of day :{greetingResp.TimeOfDay})')

greetingResp = client.service.Greet()
print(f'The greeting result from our service is: {greetingResp.Greeting} (for time of day :{greetingResp.TimeOfDay})')



