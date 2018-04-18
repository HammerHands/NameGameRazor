# NameGameRazor

## Standard Mode
 * Displays Five Faces and a name. When an image is clicked on it will display whether that is incorrect or correct. To get a new question    click the Standard in the nav menu.

## Team Mode
 * Same as Standard Mode but only shows profiles whose job title is not null. This indicates that they are current employees.

## Mat(t) Mode
 * Same as Standard Mode but only shows names that start with Mat.
 
## Reverse
 * Displays a face and five names. When a name is clicked on it will display whether that is incorrect or correct.
 
## Streak Tracking
 * Streak Tracking is implemented to track across all lists. When an question is answered correctly the streak increases by 1. If answered incorrectly the value is reset to 0. If you navigate to another page the score remains the same. 
 * E.g. Mat(t) question -> correct -> streak = 1; Standard Question -> streak = 1 -> correct -> streak = 2; Team Question -> streak = 2 -> correct -> streak = 3; Reverse Question -> streak = 3 -> incorrect -> streak = 0. 
 
## Keyboard Shortcuts
 * There are numbers displayed above each name. When the corresponding key is pressed on the keyboard the associated answer is guessed.
