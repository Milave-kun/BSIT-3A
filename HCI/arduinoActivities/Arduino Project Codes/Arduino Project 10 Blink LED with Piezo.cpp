// Arduino Project 10: Blink LED with Piezo

int photoresistorPin = A0;

void setup() {
  Serial.begin(9600);
  pinMode(photoresistorPin, INPUT);
  pinMode(9, OUTPUT);
  pinMode(13, OUTPUT);
}

void loop() {
  int lightValue = analogRead(photoresistorPin);

  if (lightValue < 300) {
    digitalWrite(9, HIGH);
    tone(13, 1000);
    delay(500);
    noTone(13);
    delay(100);
    digitalWrite(9, LOW);
    tone(13, 800);
    delay(500);
    noTone(13);
    delay(100);
  } else {
    digitalWrite(9, LOW);
    noTone(13); // Turn off the buzzer
  }

  delay(50);
}
