// Arduino Project 7: Temperature Sensor Reading

const int temperaturePin = 0;

float adcValue;
float voltage;
float degreesC;

void setup() {
  Serial.begin(9600);
}

void loop() {
  adcValue = analogRead(temperaturePin);
  voltage = (adcValue * 5) / 1023;
  degreesC = 100 * voltage - 50;

  Serial.print("ADC Value: ");
  Serial.println(adcValue);
  Serial.print("Voltage: ");
  Serial.println(voltage);
  Serial.print("Temperature: ");
  Serial.print(degreesC);
  Serial.println("°C");  // Added units for temperature
  Serial.println();

  delay(3000);
}
