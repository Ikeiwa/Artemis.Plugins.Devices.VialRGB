# VialRGB for Artemis

[Artemis](https://artemis-rgb.com/) provider for any device that supports [Vial](https://get.vial.today/) direct control lighting mode.

## Current limitations:
- Limited to 30fps max (need more testing with HID communication)
- Effects triggered by key press might be innacurate since Leds are referenced by keycode (so macro keys will not trigger effects at their location)
- Some keys do not trigger effects since vial doesn't send their keypresses (like the Fn key)
- Lighting mode doesn't correctly reset to original mode on quit
- Led keycodes are based on the Layout 0 of your device (couldn't find a way to get the current selected layout)
