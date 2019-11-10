//
//  Haptic.m
//  Haptic
//
//  Created by Nrjwolf on 10/11/2019.
//  Copyright © 2019 Nrjwolf. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

void NotificationFeedback (UINotificationFeedbackType notificationType) {
     if (@available(iOS 10.0, *)) {
         UINotificationFeedbackGenerator* notificationFeedbackGenerator = [[UINotificationFeedbackGenerator alloc] init];
         [notificationFeedbackGenerator prepare];
         [notificationFeedbackGenerator notificationOccurred:notificationType];
     }
}

void ImpactFeedback (UIImpactFeedbackStyle impactStyle) {
     if (@available(iOS 10.0, *)) {
         UIImpactFeedbackGenerator *myGen = [[UIImpactFeedbackGenerator alloc] initWithStyle:(impactStyle)];
         [myGen impactOccurred];
         myGen = NULL;
     }
}

void _IOSNotificationFeedbackError () {
    NotificationFeedback(UINotificationFeedbackTypeError);
}

void _IOSNotificationFeedbackSuccess () {
    NotificationFeedback(UINotificationFeedbackTypeSuccess);
}

void _IOSNotificationFeedbackWarning() {
    NotificationFeedback(UINotificationFeedbackTypeWarning);
}

void _IOSImpactFeedbackLight() {
    ImpactFeedback(UIImpactFeedbackStyleLight);
}

void _IOSImpactFeedbackMedium() {
    ImpactFeedback(UIImpactFeedbackStyleMedium);
}

void _IOSImpactFeedbackHeavy() {
    ImpactFeedback(UIImpactFeedbackStyleHeavy);
}

void _IOSImpactFeedbackSoft() {
    if (@available(iOS 13.0, *)) {
        ImpactFeedback(UIImpactFeedbackStyleSoft);
    } else {
        ImpactFeedback(UIImpactFeedbackStyleLight);
    }
}

void _IOSImpactFeedbackRigid() {
    if (@available(iOS 13.0, *)) {
        ImpactFeedback(UIImpactFeedbackStyleRigid);
    } else {
        ImpactFeedback(UIImpactFeedbackStyleHeavy);
    }
}

void _IOSSelectionFeedback () {
    if (@available(iOS 10.0, *)) {
        UISelectionFeedbackGenerator *feedbackGenerator = [[UISelectionFeedbackGenerator alloc] init];
        [feedbackGenerator prepare];
        [feedbackGenerator selectionChanged];
        feedbackGenerator = NULL;
    }
}
