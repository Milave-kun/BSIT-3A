const int greenLedPin = 3;
const int redLed1Pin = 4;
const int redLed2Pin = 5;
const int buttonPin = 2;

int buttonState = 0;


void setup() {
  pinMode(greenLedPin, OUTPUT);
  pinMode(redLed1Pin, OUTPUT);
  pinMode(redLed2Pin, OUTPUT);

  pinMode(buttonPin, INPUT);
}

void loop() {
  buttonState = digitalRead(buttonPin);
  if (buttonState == HIGH) {
    digitalWrite(greenLedPin, HIGH);
    delay(500);
    digitalWrite(greenLedPin, LOW);
  }
  else {
    digitalWrite(redLed1Pin, HIGH);
    delay(500);
    digitalWrite(redLed1Pin, LOW);

    digitalWrite(redLed2Pin, HIGH);
    delay(500);
    digitalWrite(redLed2Pin, LOW);
  }
}