# Usefull Git Commands

## Merge branchs

### Combine another branch commits to single commit on current branch
```groovy
// Step 1: Checkout to the <developer> branch
(local_new_feature)$ git checkout developer
// Step 2: Merge commits from <local_new_feature> branch to <developer> branch
(developer)$ git merge local_new_feature --squash
// Step 3: Commit changes to <developer>
(developer)$ git commit -m "Merge new feature to developer"
```
