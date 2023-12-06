// Arduino Project 8: Using Active Piezo

int buzzerPin = 8;
int buttonPin = 7;

void setup() {
  pinMode(buzzerPin, OUTPUT);
  pinMode(buttonPin, INPUT_PULLUP);
}

void loop() {
  int buttonState = digitalRead(buttonPin);

  if (buttonState == LOW) {
    digitalWrite(buzzerPin, HIGH);
  }

  if (buttonState == HIGH) {
    digitalWrite(buzzerPin, LOW);
  }
}
