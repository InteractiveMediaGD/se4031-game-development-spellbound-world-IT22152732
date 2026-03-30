[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/BFiB73Fc)
[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-2e0aaae1b6195c2367325f4f02e2d04e9abb55f0b24a779b69b11b9e10269abc.svg)](https://classroom.github.com/online_ide?assignment_repo_id=23346566&assignment_repo_type=AssignmentRepo)
# Assignment 03 (Individual) – GAMES DEVELOPMENT

**SE4031 – Games Development**  
**Title – Immersive VR Experience: Spellbound World**  
**Assignment Created By:** Mr. Aruna Ishara Gamage, Mr. Nushkan Nismi  
**End Digit:** 2  
**Assignment Weight:** 30%

---

## OBJECTIVE

Spellbound World

Design and develop a Virtual Reality (VR) application using Unity that immerses the player in a magical, interactive world.

Players should be able to move, cast spells using voice commands, interact with magical objects, and experience an enchanted environment. The theme can be loosely inspired by Harry Potter, but your game must include original content and mechanics.

---

## ASSIGNMENT STRUCTURE (2 Parts)

- **Part A (60%) – Based on Tutorials + Lab Sheets**  
  Students can score Part A using the concepts, techniques, and implementations covered in tutorials and lab sheets.

- **Part B (40%) – Self-Learning + Advanced Work (Required for High Grades)**  
  Part B must be completed using self-learning and independent research. Part B includes a creative challenge, and it must be unique (not copied from other students) to score marks.

---

## CORE REQUIREMENTS

## Part A Requirements (60%)

### 1. VR Movement & Locomotion

- Use teleportation or joystick-based movement.
- Allow the player to navigate and explore the environment comfortably.

### 2. Simplified Interactable

- Collectable Magic Items: Scrolls or crystals that can be picked up with controller or pointer interaction.
- Target-Based Spell Interactions: Spawn targets (e.g., floating orbs) that respond when hit with spells.
- Interactive Spell Training Book: Display spell names/lore when approached or selected.

### 3. VR UI Elements

- Include a HUD or VR-friendly UI display:
  - Current spell
  - Objectives or instructions
  - Optional health/magic bar

---

## Part B Requirements (40%) – Self Learning

### 4. Spell Casting System (Voice Input Only)

- The player must be able to cast at least three (3) different spells using voice commands only (no gestures or button presses).

Example Spells (DO NOT USE):

- “Fireball” – Launch a projectile toward a target.
- “Levitate” – Make a nearby object float.
- “Lumos” – Emit light from a wand or magical object.

#### IMPORTANT NOTE

- The spell words mentioned above are EXAMPLES ONLY.
- Students must create their own original spell words.
- Using the example spell words exactly as given above will result in 0 marks for the spellcasting component.

The system must:

- Accurately detect commands using voice input tools (e.g., Windows Speech API (wit.ai).
- Provide visual/audio feedback upon successful spell recognition.
- Show a response or warning for unrecognized spells.
- When the application is built and executed directly on a VR headset, the Windows Speech API will not function. However, the same voice command system will work correctly when the application is built as a Windows Desktop (.exe) and run on a PC with a connected VR headset.

### 5. Voice Command Integration

- Integrate a speech recognition system to handle spell inputs.
- Ensure the recognition is real-time and reliable during gameplay.

### 6. Visual & Audio Immersion

- Use high-quality textures, magical particle effects, and ambient/spatial audio.
- Include sounds for footsteps, voice commands, and magical effects.

### 7. Magical Challenge Area

- Include a special test zone where the player uses spells and interactions to:
  - Destroy a group of targets
  - Complete a spellcasting challenge

⚠️ Part B Creative Challenge Note

Part B includes a creative challenge, and it must be unique (not copied from other students) to score marks.

---

## Folder Structure & Code

- Must follow the folder structure.
- Project must be structured with well-named assets/scripts.

---

## Game Documentation

- Submit a PDF with:
  - Title, student name, and IT number
  - Game summary and spell list
  - Screenshots of gameplay
  - Control guide (movement, voice usage)
  - Credits for any assets/tools used

---

## Submission Requirements

### Windows .exe Build

Include .exe and Data folder, playable with a VR headset.

### Zipped Unity Project Folder

Must follow the folder structure.  
Upload to a shared Google Drive folder in Courseweb.

### Gameplay Demo Video

- 5 minutes showcasing:
  - Voice-activated spellcasting
  - Movement
  - Item collection and target interaction
  - Spellbook interaction
  - Challenge zone gameplay

---

## PLAGIARISM / ORIGINALITY VERIFICATION (VIVA)

- A mandatory one-to-one viva will be conducted
- Students must clearly explain:
  - Voice command logic
  - System interaction behavior
  - Emergency challenge design
- Failure to justify originality may result in mark deductions or zero marks

---

## Assessment Rubric (Part A + Part B)

## Part A (60 Marks)

| Criteria | Excellent | Good | Satisfactory | Poor | Marks |
|---------|-----------|------|--------------|------|-------|
| VR Movement | Smooth and immersive navigation implemented | Navigation implemented with minor issues | Basic navigation implemented with limitations | No or broken navigation | 12 |
| Magical Interactable | All 3 types fully implemented and functional | 2 types working with minor issues | 1 interactable working or with bugs | No meaningful interactables | 12 |
| VR UI Elements | Clear VR-friendly HUD with objectives and indicators | UI mostly clear with minor issues | Basic UI with limited usefulness | No VR UI elements | 10 |
| Folder Structure & Code | Fully structured project with well-named assets/scripts | Mostly structured with a few misplacements | Some structure present but inconsistent | Disorganized or missing structure | 8 |
| Game Documentation | Full PDF with all required sections, neat and informative | PDF mostly complete with some minor details missing | Basic write-up, lacks detail | No documentation submitted | 8 |
| **Part A Total** |  |  |  |  | **60** |

---

## Part B (40 Marks) – Self Learning

| Criteria | Excellent (Full Marks) | Good | Satisfactory | Poor | Marks |
|---------|--------------------------|------|--------------|------|-------|
| Spellcasting (Voice Only) | 3 unique spells cast accurately via voice with VFX/SFX | 2 working voice spells, 1 partial | Only 1 working spell or partially functioning voice | Spells missing or not voice controlled | 20 |
| Voice Command Integration | Voice system is stable, responsive, with clear feedback | Minor delays or detection issues | Frequently unresponsive voice commands | Not implemented or unusable | 12 |
| Visual/Audio Immersion + Magical Challenge Area | Excellent textures/lighting/audio + Fully playable unique challenge area requiring spell use | Good immersion + challenge exists with minor functionality | Basic visuals/audio + basic room with no real challenge | Poor or missing immersion/challenge | 8 |
| **Part B Total** |  |  |  |  | **40** |

Plagiarism / Originality Verification (Viva)
